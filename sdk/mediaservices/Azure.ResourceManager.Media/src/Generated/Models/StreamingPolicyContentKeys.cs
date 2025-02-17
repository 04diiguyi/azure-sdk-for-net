// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Class to specify properties of all content keys in Streaming Policy. </summary>
    public partial class StreamingPolicyContentKeys
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyContentKeys"/>. </summary>
        public StreamingPolicyContentKeys()
        {
            KeyToTrackMappings = new ChangeTrackingList<StreamingPolicyContentKey>();
        }

        /// <summary> Initializes a new instance of <see cref="StreamingPolicyContentKeys"/>. </summary>
        /// <param name="defaultKey"> Default content key for an encryption scheme. </param>
        /// <param name="keyToTrackMappings"> Representing tracks needs separate content key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StreamingPolicyContentKeys(EncryptionSchemeDefaultKey defaultKey, IList<StreamingPolicyContentKey> keyToTrackMappings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DefaultKey = defaultKey;
            KeyToTrackMappings = keyToTrackMappings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Default content key for an encryption scheme. </summary>
        public EncryptionSchemeDefaultKey DefaultKey { get; set; }
        /// <summary> Representing tracks needs separate content key. </summary>
        public IList<StreamingPolicyContentKey> KeyToTrackMappings { get; }
    }
}
