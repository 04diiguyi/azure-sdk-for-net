// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.DevTestLabs;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of a virtual machine that determine how it is connected to a load balancer. </summary>
    internal partial class SharedPublicIPAddressConfiguration
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

        /// <summary> Initializes a new instance of <see cref="SharedPublicIPAddressConfiguration"/>. </summary>
        public SharedPublicIPAddressConfiguration()
        {
            InboundNatRules = new ChangeTrackingList<DevTestLabInboundNatRule>();
        }

        /// <summary> Initializes a new instance of <see cref="SharedPublicIPAddressConfiguration"/>. </summary>
        /// <param name="inboundNatRules"> The incoming NAT rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SharedPublicIPAddressConfiguration(IList<DevTestLabInboundNatRule> inboundNatRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            InboundNatRules = inboundNatRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The incoming NAT rules. </summary>
        public IList<DevTestLabInboundNatRule> InboundNatRules { get; }
    }
}
