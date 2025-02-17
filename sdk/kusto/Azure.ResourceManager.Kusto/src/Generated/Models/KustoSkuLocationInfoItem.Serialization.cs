// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Kusto;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoSkuLocationInfoItem : IUtf8JsonSerializable, IJsonModel<KustoSkuLocationInfoItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoSkuLocationInfoItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KustoSkuLocationInfoItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoSkuLocationInfoItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoSkuLocationInfoItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ZoneDetails))
            {
                writer.WritePropertyName("zoneDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ZoneDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        KustoSkuLocationInfoItem IJsonModel<KustoSkuLocationInfoItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoSkuLocationInfoItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoSkuLocationInfoItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoSkuLocationInfoItem(document.RootElement, options);
        }

        internal static KustoSkuLocationInfoItem DeserializeKustoSkuLocationInfoItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation location = default;
            IReadOnlyList<string> zones = default;
            IReadOnlyList<KustoResourceSkuZoneDetails> zoneDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("zoneDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<KustoResourceSkuZoneDetails> array = new List<KustoResourceSkuZoneDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(KustoResourceSkuZoneDetails.DeserializeKustoResourceSkuZoneDetails(item, options));
                    }
                    zoneDetails = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KustoSkuLocationInfoItem(location, zones ?? new ChangeTrackingList<string>(), zoneDetails ?? new ChangeTrackingList<KustoResourceSkuZoneDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KustoSkuLocationInfoItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoSkuLocationInfoItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KustoSkuLocationInfoItem)} does not support '{options.Format}' format.");
            }
        }

        KustoSkuLocationInfoItem IPersistableModel<KustoSkuLocationInfoItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoSkuLocationInfoItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKustoSkuLocationInfoItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KustoSkuLocationInfoItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoSkuLocationInfoItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
