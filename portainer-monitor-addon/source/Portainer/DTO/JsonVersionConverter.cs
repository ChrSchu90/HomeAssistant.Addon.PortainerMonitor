namespace HomeAssistant.Addon.PortainerMonitor.Portainer.DTO;

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

/// <summary>
/// Json converter for <see cref="Version"/> handling
/// </summary>
internal class JsonVersionConverter : JsonConverter<Version>
{
    /// <inheritdoc />
    public override Version Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var versionStr = reader.GetString();
        return Version.TryParse(versionStr, out var version)
                   ? version
                   : new Version(0, 0, 0);
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}