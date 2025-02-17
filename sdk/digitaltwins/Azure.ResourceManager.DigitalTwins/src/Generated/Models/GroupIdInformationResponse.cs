// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DigitalTwins;

namespace Azure.ResourceManager.DigitalTwins.Models
{
    /// <summary> The available private link resources for a Digital Twin. </summary>
    internal partial class GroupIdInformationResponse
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

        /// <summary> Initializes a new instance of <see cref="GroupIdInformationResponse"/>. </summary>
        internal GroupIdInformationResponse()
        {
            Value = new ChangeTrackingList<DigitalTwinsPrivateLinkResourceData>();
        }

        /// <summary> Initializes a new instance of <see cref="GroupIdInformationResponse"/>. </summary>
        /// <param name="value"> The list of available private link resources for a Digital Twin. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GroupIdInformationResponse(IReadOnlyList<DigitalTwinsPrivateLinkResourceData> value, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The list of available private link resources for a Digital Twin. </summary>
        public IReadOnlyList<DigitalTwinsPrivateLinkResourceData> Value { get; }
    }
}
