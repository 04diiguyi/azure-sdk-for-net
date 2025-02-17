// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The JitNetworkAccessRequestPort. </summary>
    public partial class JitNetworkAccessRequestPort
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

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessRequestPort"/>. </summary>
        /// <param name="number"></param>
        /// <param name="endOn"> The date &amp; time at which the request ends in UTC. </param>
        /// <param name="status"> The status of the port. </param>
        /// <param name="statusReason"> A description of why the `status` has its value. </param>
        public JitNetworkAccessRequestPort(int number, DateTimeOffset endOn, JitNetworkAccessPortStatus status, JitNetworkAccessPortStatusReason statusReason)
        {
            Number = number;
            AllowedSourceAddressPrefixes = new ChangeTrackingList<string>();
            EndOn = endOn;
            Status = status;
            StatusReason = statusReason;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessRequestPort"/>. </summary>
        /// <param name="number"></param>
        /// <param name="allowedSourceAddressPrefix"> Mutually exclusive with the "allowedSourceAddressPrefixes" parameter. Should be an IP address or CIDR, for example "192.168.0.3" or "192.168.0.0/16". </param>
        /// <param name="allowedSourceAddressPrefixes"> Mutually exclusive with the "allowedSourceAddressPrefix" parameter. </param>
        /// <param name="endOn"> The date &amp; time at which the request ends in UTC. </param>
        /// <param name="status"> The status of the port. </param>
        /// <param name="statusReason"> A description of why the `status` has its value. </param>
        /// <param name="mappedPort"> The port which is mapped to this port's `number` in the Azure Firewall, if applicable. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitNetworkAccessRequestPort(int number, string allowedSourceAddressPrefix, IList<string> allowedSourceAddressPrefixes, DateTimeOffset endOn, JitNetworkAccessPortStatus status, JitNetworkAccessPortStatusReason statusReason, int? mappedPort, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Number = number;
            AllowedSourceAddressPrefix = allowedSourceAddressPrefix;
            AllowedSourceAddressPrefixes = allowedSourceAddressPrefixes;
            EndOn = endOn;
            Status = status;
            StatusReason = statusReason;
            MappedPort = mappedPort;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessRequestPort"/> for deserialization. </summary>
        internal JitNetworkAccessRequestPort()
        {
        }

        /// <summary> Gets or sets the number. </summary>
        public int Number { get; set; }
        /// <summary> Mutually exclusive with the "allowedSourceAddressPrefixes" parameter. Should be an IP address or CIDR, for example "192.168.0.3" or "192.168.0.0/16". </summary>
        public string AllowedSourceAddressPrefix { get; set; }
        /// <summary> Mutually exclusive with the "allowedSourceAddressPrefix" parameter. </summary>
        public IList<string> AllowedSourceAddressPrefixes { get; }
        /// <summary> The date &amp; time at which the request ends in UTC. </summary>
        public DateTimeOffset EndOn { get; set; }
        /// <summary> The status of the port. </summary>
        public JitNetworkAccessPortStatus Status { get; set; }
        /// <summary> A description of why the `status` has its value. </summary>
        public JitNetworkAccessPortStatusReason StatusReason { get; set; }
        /// <summary> The port which is mapped to this port's `number` in the Azure Firewall, if applicable. </summary>
        public int? MappedPort { get; set; }
    }
}
