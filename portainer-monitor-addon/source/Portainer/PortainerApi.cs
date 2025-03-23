namespace HomeAssistant.Addon.PortainerMonitor.Portainer;

using System;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using HomeAssistant.Addon.PortainerMonitor.Portainer.ApiModels;
using RestSharp;
using Serilog;

/// <inheritdoc cref="IPortainerApi" />
internal class PortainerApi : IPortainerApi, IDisposable
{
    #region Private Static Fields

    #endregion

    #region Private Fields

    private readonly IPortainerConfig _config;
    private readonly CancellationToken _ct;
    private readonly RestClient _client;

    #endregion

    #region Constructors

    /// <summary>
    /// Initializes a new instance of the <see cref="PortainerApi" /> class.
    /// </summary>
    /// <param name="config">The configuration.</param>
    /// <param name="ct">A cancellation token to cancel all requests.</param>
    internal PortainerApi(IPortainerConfig config, CancellationToken ct = default)
    {
        _config = config;
        _ct = ct;
        _client = new RestClient(new RestClientOptions($"{(_config.TlsEnabled ? "https" : "http")}://{_config.Host}:{_config.Port}/api")
        {
            RemoteCertificateValidationCallback = RemoteCertificateValidationCallback,
            Timeout = TimeSpan.FromSeconds(15)
        });

        _client.AddDefaultHeader("X-API-Key", config.Token);
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
    public Task<SystemVersionResponse?> GetVersionAsync()
    {
        return TryGetAsync<SystemVersionResponse>(new RestRequest("/system/version"));
    }

    /// <inheritdoc />
    public Task<PortainerEndpoint[]?> GetEndpointsAsync()
    {
        return TryGetAsync<PortainerEndpoint[]>(new RestRequest("/endpoints"));
    }

    /// <inheritdoc />
    public Task<DockerContainer[]?> GetAllContainersAsync(int endpointId, bool all = true)
    {
        return TryGetAsync<DockerContainer[]?>(new RestRequest($"/endpoints/{endpointId}/docker/containers/json").AddParameter(new GetOrPostParameter("all", $"{all}")));
    }

    /// <inheritdoc />
    public Task<bool> StartContainer(int endpointId, string containerId)
    {
        return TryPostAsync(new RestRequest($"/endpoints/{endpointId}/docker/containers/{containerId}/start", Method.Post));
    }

    /// <inheritdoc />
    public Task<bool> StopContainer(int endpointId, string containerId)
    {
        return TryPostAsync(new RestRequest($"/endpoints/{endpointId}/docker/containers/{containerId}/stop", Method.Post));
    }

    /// <inheritdoc />
    public Task<bool> PauseContainer(int endpointId, string containerId)
    {
        return TryPostAsync(new RestRequest($"/endpoints/{endpointId}/docker/containers/{containerId}/pause", Method.Post));
    }

    /// <inheritdoc />
    public Task<bool> UnpauseContainer(int endpointId, string containerId)
    {
        return TryPostAsync(new RestRequest($"/endpoints/{endpointId}/docker/containers/{containerId}/unpause", Method.Post));
    }

    /// <inheritdoc />
    public Task<bool> RestartContainer(int endpointId, string containerId, ushort killTimeout = 30)
    {
        var request = new RestRequest($"/endpoints/{endpointId}/docker/containers/{containerId}/restart", Method.Post).AddParameter("t", $"{killTimeout}");
        request.Timeout = TimeSpan.FromSeconds(killTimeout) + _client.Options.Timeout; 
        return TryPostAsync(request);
    }

    #endregion

    #region Private Methods

    private async Task<T?> TryGetAsync<T>(RestRequest req, [CallerMemberName] string? apiFuncName = null)
    {
        try
        {
            var res = await _client.GetAsync(req, _ct).ConfigureAwait(false);
            res.ThrowIfError();

            var response = _client.Serializers.DeserializeContent<T?>(res);
            if (response != null) Log.Verbose($"Portainer API `{_config.DisplayName}` `{apiFuncName}` `{req.Resource}`:\n{res.Content}");
            return response;
        }
        catch (OperationCanceledException) { return default; }
        catch (Exception err)
        {
            if (!_ct.IsCancellationRequested) Log.Error(err, $"Portainer API `{_config.DisplayName}` error `{apiFuncName}` `{req.Resource}`");
            return default;
        }
    }

    private async Task<bool> TryPostAsync(RestRequest req, [CallerMemberName] string? apiFuncName = null)
    {
        try
        {
            var res = await _client.PostAsync(req, _ct).ConfigureAwait(false);
            res.ThrowIfError();
            var successful = res.StatusCode is HttpStatusCode.OK or HttpStatusCode.NoContent;
            if (successful) 
                Log.Verbose($"Portainer API `{_config.DisplayName}` `{apiFuncName}` `{req.Resource}` successfully sent ({(int)res.StatusCode})");
            else 
                Log.Error($"Portainer API `{_config.DisplayName}` `{apiFuncName}` `{req.Resource}` failed ({(int)res.StatusCode})\n{res.Content}");
            return successful;
        }
        catch (OperationCanceledException) { return false; }
        catch (Exception err)
        {
            if (!_ct.IsCancellationRequested) Log.Error(err, $"Portainer API `{_config.DisplayName}` error `{apiFuncName}` `{req.Resource}`");
            return false;
        }
    }

    private bool RemoteCertificateValidationCallback(object sender, X509Certificate? certificate, X509Chain? chain, SslPolicyErrors sslPolicyErrors)
    {
        if (!_config.TlsValidate || sslPolicyErrors == SslPolicyErrors.None) return true;

        if (certificate == null || chain == null) return false;
        using var cert = new X509Certificate2(certificate);
        return chain.Build(cert);
    }

    #endregion
}