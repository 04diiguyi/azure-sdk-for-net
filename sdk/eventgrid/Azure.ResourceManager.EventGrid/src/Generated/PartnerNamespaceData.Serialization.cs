// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.EventGrid.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.EventGrid
{
    public partial class PartnerNamespaceData : IUtf8JsonSerializable, IJsonModel<PartnerNamespaceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PartnerNamespaceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PartnerNamespaceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerNamespaceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(PartnerRegistrationFullyQualifiedId))
            {
                writer.WritePropertyName("partnerRegistrationFullyQualifiedId"u8);
                writer.WriteStringValue(PartnerRegistrationFullyQualifiedId);
            }
            if (Optional.IsDefined(MinimumTlsVersionAllowed))
            {
                writer.WritePropertyName("minimumTlsVersionAllowed"u8);
                writer.WriteStringValue(MinimumTlsVersionAllowed.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(Endpoint))
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint.AbsoluteUri);
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsCollectionDefined(InboundIPRules))
            {
                writer.WritePropertyName("inboundIpRules"u8);
                writer.WriteStartArray();
                foreach (var item in InboundIPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsLocalAuthDisabled))
            {
                writer.WritePropertyName("disableLocalAuth"u8);
                writer.WriteBooleanValue(IsLocalAuthDisabled.Value);
            }
            if (Optional.IsDefined(PartnerTopicRoutingMode))
            {
                writer.WritePropertyName("partnerTopicRoutingMode"u8);
                writer.WriteStringValue(PartnerTopicRoutingMode.Value.ToString());
            }
            writer.WriteEndObject();
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

        PartnerNamespaceData IJsonModel<PartnerNamespaceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PartnerNamespaceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePartnerNamespaceData(document.RootElement, options);
        }

        internal static PartnerNamespaceData DeserializePartnerNamespaceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            IReadOnlyList<EventGridPrivateEndpointConnectionData> privateEndpointConnections = default;
            PartnerNamespaceProvisioningState? provisioningState = default;
            ResourceIdentifier partnerRegistrationFullyQualifiedId = default;
            TlsVersion? minimumTlsVersionAllowed = default;
            Uri endpoint = default;
            EventGridPublicNetworkAccess? publicNetworkAccess = default;
            IList<EventGridInboundIPRule> inboundIPRules = default;
            bool? disableLocalAuth = default;
            PartnerTopicRoutingMode? partnerTopicRoutingMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventGridPrivateEndpointConnectionData> array = new List<EventGridPrivateEndpointConnectionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventGridPrivateEndpointConnectionData.DeserializeEventGridPrivateEndpointConnectionData(item, options));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new PartnerNamespaceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("partnerRegistrationFullyQualifiedId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerRegistrationFullyQualifiedId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("minimumTlsVersionAllowed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            minimumTlsVersionAllowed = new TlsVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endpoint"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endpoint = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new EventGridPublicNetworkAccess(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("inboundIpRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EventGridInboundIPRule> array = new List<EventGridInboundIPRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EventGridInboundIPRule.DeserializeEventGridInboundIPRule(item, options));
                            }
                            inboundIPRules = array;
                            continue;
                        }
                        if (property0.NameEquals("disableLocalAuth"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disableLocalAuth = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("partnerTopicRoutingMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partnerTopicRoutingMode = new PartnerTopicRoutingMode(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PartnerNamespaceData(
                id,
                name,
                type,
                systemData,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                location,
                privateEndpointConnections ?? new ChangeTrackingList<EventGridPrivateEndpointConnectionData>(),
                provisioningState,
                partnerRegistrationFullyQualifiedId,
                minimumTlsVersionAllowed,
                endpoint,
                publicNetworkAccess,
                inboundIPRules ?? new ChangeTrackingList<EventGridInboundIPRule>(),
                disableLocalAuth,
                partnerTopicRoutingMode,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PartnerNamespaceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PartnerNamespaceData)} does not support '{options.Format}' format.");
            }
        }

        PartnerNamespaceData IPersistableModel<PartnerNamespaceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PartnerNamespaceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePartnerNamespaceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PartnerNamespaceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PartnerNamespaceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
