// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsIncomingCallCustomContext
    {
        internal static AcsIncomingCallCustomContext DeserializeAcsIncomingCallCustomContext(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyDictionary<string, string> sipHeaders = default;
            IReadOnlyDictionary<string, string> voipHeaders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sipHeaders"u8))
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
                    sipHeaders = dictionary;
                    continue;
                }
                if (property.NameEquals("voipHeaders"u8))
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
                    voipHeaders = dictionary;
                    continue;
                }
            }
            return new AcsIncomingCallCustomContext(sipHeaders ?? new ChangeTrackingDictionary<string, string>(), voipHeaders ?? new ChangeTrackingDictionary<string, string>());
        }
    }
}
