// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownTestFailoverProviderSpecificContent))]
    public partial class TestFailoverProviderSpecificContent : IUtf8JsonSerializable, IJsonModel<TestFailoverProviderSpecificContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TestFailoverProviderSpecificContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TestFailoverProviderSpecificContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverProviderSpecificContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        TestFailoverProviderSpecificContent IJsonModel<TestFailoverProviderSpecificContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TestFailoverProviderSpecificContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTestFailoverProviderSpecificContent(document.RootElement, options);
        }

        internal static TestFailoverProviderSpecificContent DeserializeTestFailoverProviderSpecificContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return A2ATestFailoverContent.DeserializeA2ATestFailoverContent(element, options);
                    case "HyperVReplicaAzure": return HyperVReplicaAzureTestFailoverContent.DeserializeHyperVReplicaAzureTestFailoverContent(element, options);
                    case "InMage": return InMageTestFailoverContent.DeserializeInMageTestFailoverContent(element, options);
                    case "InMageAzureV2": return InMageAzureV2TestFailoverContent.DeserializeInMageAzureV2TestFailoverContent(element, options);
                    case "InMageRcm": return InMageRcmTestFailoverContent.DeserializeInMageRcmTestFailoverContent(element, options);
                }
            }
            return UnknownTestFailoverProviderSpecificContent.DeserializeUnknownTestFailoverProviderSpecificContent(element, options);
        }

        BinaryData IPersistableModel<TestFailoverProviderSpecificContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TestFailoverProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        TestFailoverProviderSpecificContent IPersistableModel<TestFailoverProviderSpecificContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TestFailoverProviderSpecificContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTestFailoverProviderSpecificContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TestFailoverProviderSpecificContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TestFailoverProviderSpecificContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
