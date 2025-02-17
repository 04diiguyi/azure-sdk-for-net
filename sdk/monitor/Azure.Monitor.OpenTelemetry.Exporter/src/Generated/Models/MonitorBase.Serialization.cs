// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.Monitor.OpenTelemetry.Exporter;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    internal partial class MonitorBase : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseType))
            {
                writer.WritePropertyName("baseType"u8);
                writer.WriteStringValue(BaseType);
            }
            if (Optional.IsDefined(BaseData))
            {
                writer.WritePropertyName("baseData"u8);
                writer.WriteObjectValue(BaseData);
            }
            writer.WriteEndObject();
        }
    }
}
