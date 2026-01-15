namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

using HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;
using RestSharp;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/// <inheritdoc cref="IAgentApi" />
internal class AgentApi : IAgentApi, IDisposable
{
    #region Private Static Fields

    /// <summary>
    /// An empty json object
    /// </summary>
    private const string EmptyJson = "{\n}";

    /// <summary>
    /// The default agent signature message if no <c>AGENT_SECRET</c> is defined
    /// </summary>
    private const string DefaultAgentSignatureMessage = "Portainer-App";

    #endregion

    #region Private Fields

    private readonly IAgentConfig _config;
    private readonly CancellationToken _ct;
    private readonly RestClient _client;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="AgentApi" /> class.
    /// </summary>
    /// <param name="config">The configuration.</param>
    /// <param name="ct">A cancellation token to cancel all requests.</param>
    internal AgentApi(IAgentConfig config, CancellationToken ct = default)
    {
        _config = config;
        _ct = ct;

        _client = new RestClient(new RestClientOptions($"{(_config.TlsEnabled ? "https" : "http")}://{_config.Host}:{_config.Port}")
        {
            RemoteCertificateValidationCallback = RemoteCertificateValidationCallback,
            Timeout = TimeSpan.FromSeconds(15)
        });

        using var signature = ECDsa.Create(ECCurve.NamedCurves.nistP256);

        var publicKeyBytes = signature.ExportSubjectPublicKeyInfo();
        var publicKeyEncoded = BitConverter.ToString(publicKeyBytes).Replace("-", string.Empty).ToLower();
        _client.AddDefaultHeader("X-PortainerAgent-PublicKey", publicKeyEncoded);

        var signedHash = signature.SignData(Encoding.UTF8.GetBytes(config.Secret ?? DefaultAgentSignatureMessage), HashAlgorithmName.MD5);
        var base64Hash = Convert.ToBase64String(signedHash, Base64FormattingOptions.None).TrimEnd('=');
        _client.AddDefaultHeader("X-PortainerAgent-Signature", base64Hash);
    }

    #endregion

    #region Events

    #endregion

    #region Properties

    /// <inheritdoc />
    public string DisplayName => _config.DisplayName;

    /// <inheritdoc />
    public string ID => _config.Id;

    #endregion

    #region Public Methods

    /// <inheritdoc />
    public void Dispose()
    {
        _client.Dispose();
    }

    /// <inheritdoc />
    public async Task<Version?> GetAgentVersionAsync()
    {
        var req = new RestRequest("ping");
        try
        {
            var res = await _client.GetAsync(req, _ct).ConfigureAwait(false);
            res.ThrowIfError();
            return Version.TryParse(res.GetHeaderValue("Portainer-Agent"), out var agentVersion) ? agentVersion : new Version(0, 0, 0);
        }
        catch (OperationCanceledException) { return null; }
        catch (Exception err)
        {
            if (!_ct.IsCancellationRequested) Log.Error(err, $"Agent API `{_config.DisplayName}` error `{nameof(GetAgentVersionAsync)}` `{req.Resource}`");
            return null;
        }
    }

    /// <inheritdoc />
    public Task<DockerVersionInfo?> GetDockerVersionInfoAsync()
    {
        return TryGetAsync<DockerVersionInfo>(new RestRequest("version"));
    }

    /// <inheritdoc />
    public Task<DockerContainer[]?> GetAllContainersAsync(bool all = true)
    {
        return TryGetAsync<DockerContainer[]?>(new RestRequest("containers/json").AddParameter(new GetOrPostParameter("all", $"{all}")));
    }

    /// <inheritdoc />
    public Task<ContainerStats?> GetContainerStatsAsync(string containerId)
    {
        return TryGetAsync<ContainerStats>(new RestRequest($"containers/{containerId}/stats").AddParameter("stream", false).AddParameter("one-shot", true));
    }

    /// <inheritdoc />
    public async IAsyncEnumerable<ContainerStats> GetContainerStatsStreamAsync(string containerId, [EnumeratorCancellation] CancellationToken ct = default)
    {
        var response = _client.StreamJsonAsync<ContainerStats>($"containers/{containerId}/stats", _ct);
        await foreach (var item in response.ConfigureAwait(false))
        {
            yield return item;
        }
    }

    /// <inheritdoc />
    public Task<bool> StartContainerAsync(string containerId)
    {
        return TryPostAsync(new RestRequest($"containers/{containerId}/start").AddBody(EmptyJson, ContentType.Json));
    }

    /// <inheritdoc />
    public Task<bool> StopContainerAsync(string containerId)
    {
        return TryPostAsync(new RestRequest($"containers/{containerId}/stop").AddBody(EmptyJson, ContentType.Json));
    }

    /// <inheritdoc />
    public Task<bool> PauseContainerAsync(string containerId)
    {
        return TryPostAsync(new RestRequest($"containers/{containerId}/pause").AddBody(EmptyJson, ContentType.Json));
    }

    /// <inheritdoc />
    public Task<bool> UnpauseContainerAsync(string containerId)
    {
        return TryPostAsync(new RestRequest($"containers/{containerId}/unpause").AddBody(EmptyJson, ContentType.Json));
    }

    /// <inheritdoc />
    public Task<bool> RestartContainerAsync(string containerId, ushort killTimeout = 30)
    {
        return TryPostAsync(new RestRequest($"containers/{containerId}/restart") { Timeout = TimeSpan.FromSeconds(killTimeout) + _client.Options.Timeout }.AddParameter("t", $"{killTimeout}").AddBody(EmptyJson, ContentType.Json));
    }

    #endregion

    #region Private Methods

    private async Task<T?> TryGetAsync<T>(RestRequest req, [CallerMemberName] string? apiFuncName = null)
    {
        try
        {
            req.Method = Method.Get;
            var res = await _client.GetAsync(req, _ct).ConfigureAwait(false);
            res.ThrowIfError();
            var response = _client.Serializers.DeserializeContent<T?>(res);
            if (response != null) Log.Verbose($"Agent API `{_config.DisplayName}` `{apiFuncName}` `{req.Resource}`:\n{res.Content}");
            return response;
        }
        catch (OperationCanceledException) { return default; }
        catch (Exception err)
        {
            if (!_ct.IsCancellationRequested) Log.Error(err, $"Agent API `{_config.DisplayName}` error `{apiFuncName}` `{req.Resource}`");
            return default;
        }
    }

    private async Task<bool> TryPostAsync(RestRequest req, [CallerMemberName] string? apiFuncName = null)
    {
        try
        {
            req.Method = Method.Post;
            var res = await _client.PostAsync(req, _ct).ConfigureAwait(false);
            res.ThrowIfError();
            var successful = res.StatusCode is HttpStatusCode.OK or HttpStatusCode.NoContent;
            if (successful)
                Log.Verbose($"Agent API `{_config.DisplayName}` `{apiFuncName}` `{req.Resource}` successfully sent ({(int)res.StatusCode})");
            else
                Log.Error($"Agent API `{_config.DisplayName}` `{apiFuncName}` `{req.Resource}` failed ({(int)res.StatusCode})\n{res.Content}");
            return successful;
        }
        catch (OperationCanceledException) { return false; }
        catch (Exception err)
        {
            if (!_ct.IsCancellationRequested) Log.Error(err, $"Agent API `{_config.DisplayName}` error `{apiFuncName}` `{req.Resource}`");
            return false;
        }
    }

    private bool RemoteCertificateValidationCallback(object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
    {
        return !_config.TlsValidate || sslPolicyErrors == SslPolicyErrors.None;
    }

    #endregion
}