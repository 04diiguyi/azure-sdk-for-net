// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(ContainerServiceClusterSupportEventDataConverter))]
    public partial class ContainerServiceClusterSupportEventData
    {
        internal static ContainerServiceClusterSupportEventData DeserializeContainerServiceClusterSupportEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kubernetesVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kubernetesVersion"u8))
                {
                    kubernetesVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerServiceClusterSupportEventData(kubernetesVersion);
        }

        internal partial class ContainerServiceClusterSupportEventDataConverter : JsonConverter<ContainerServiceClusterSupportEventData>
        {
            public override void Write(Utf8JsonWriter writer, ContainerServiceClusterSupportEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override ContainerServiceClusterSupportEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeContainerServiceClusterSupportEventData(document.RootElement);
            }
        }
    }
}
