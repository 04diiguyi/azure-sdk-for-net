// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.PaloAltoNetworks.Ngfw;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> VwanInfo for Firewall Networking. </summary>
    public partial class FirewallVwanConfiguration
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

        /// <summary> Initializes a new instance of <see cref="FirewallVwanConfiguration"/>. </summary>
        /// <param name="vhub"> vHub Address. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="vhub"/> is null. </exception>
        public FirewallVwanConfiguration(IPAddressSpaceInfo vhub)
        {
            Argument.AssertNotNull(vhub, nameof(vhub));

            Vhub = vhub;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallVwanConfiguration"/>. </summary>
        /// <param name="networkVirtualApplianceId"> Network Virtual Appliance resource ID. </param>
        /// <param name="vhub"> vHub Address. </param>
        /// <param name="trustSubnet"> Trust Subnet. </param>
        /// <param name="unTrustSubnet"> Untrust Subnet. </param>
        /// <param name="ipOfTrustSubnetForUdr"> IP of trust subnet for UDR. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FirewallVwanConfiguration(string networkVirtualApplianceId, IPAddressSpaceInfo vhub, IPAddressSpaceInfo trustSubnet, IPAddressSpaceInfo unTrustSubnet, IPAddressInfo ipOfTrustSubnetForUdr, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NetworkVirtualApplianceId = networkVirtualApplianceId;
            Vhub = vhub;
            TrustSubnet = trustSubnet;
            UnTrustSubnet = unTrustSubnet;
            IPOfTrustSubnetForUdr = ipOfTrustSubnetForUdr;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FirewallVwanConfiguration"/> for deserialization. </summary>
        internal FirewallVwanConfiguration()
        {
        }

        /// <summary> Network Virtual Appliance resource ID. </summary>
        public string NetworkVirtualApplianceId { get; set; }
        /// <summary> vHub Address. </summary>
        public IPAddressSpaceInfo Vhub { get; set; }
        /// <summary> Trust Subnet. </summary>
        public IPAddressSpaceInfo TrustSubnet { get; set; }
        /// <summary> Untrust Subnet. </summary>
        public IPAddressSpaceInfo UnTrustSubnet { get; set; }
        /// <summary> IP of trust subnet for UDR. </summary>
        public IPAddressInfo IPOfTrustSubnetForUdr { get; set; }
    }
}
