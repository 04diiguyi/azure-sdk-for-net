// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> The InternalNetwork patch resource definition. </summary>
    public partial class NetworkFabricInternalNetworkPatch
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

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternalNetworkPatch"/>. </summary>
        public NetworkFabricInternalNetworkPatch()
        {
            ConnectedIPv4Subnets = new ChangeTrackingList<ConnectedSubnet>();
            ConnectedIPv6Subnets = new ChangeTrackingList<ConnectedSubnet>();
        }

        /// <summary> Initializes a new instance of <see cref="NetworkFabricInternalNetworkPatch"/>. </summary>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="mtu"> Maximum transmission unit. Default value is 1500. </param>
        /// <param name="connectedIPv4Subnets"> List of Connected IPv4 Subnets. </param>
        /// <param name="connectedIPv6Subnets"> List of connected IPv6 Subnets. </param>
        /// <param name="importRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="exportRoutePolicyId"> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </param>
        /// <param name="importRoutePolicy"> Import Route Policy either IPv4 or IPv6. </param>
        /// <param name="exportRoutePolicy"> Export Route Policy either IPv4 or IPv6. </param>
        /// <param name="ingressAclId"> Ingress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="egressAclId"> Egress Acl. ARM resource ID of Access Control Lists. </param>
        /// <param name="isMonitoringEnabled"> To check whether monitoring of internal network is enabled or not. </param>
        /// <param name="bgpConfiguration"> BGP configuration properties. </param>
        /// <param name="staticRouteConfiguration"> Static Route Configuration properties. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetworkFabricInternalNetworkPatch(string annotation, int? mtu, IList<ConnectedSubnet> connectedIPv4Subnets, IList<ConnectedSubnet> connectedIPv6Subnets, ResourceIdentifier importRoutePolicyId, ResourceIdentifier exportRoutePolicyId, ImportRoutePolicy importRoutePolicy, ExportRoutePolicy exportRoutePolicy, ResourceIdentifier ingressAclId, ResourceIdentifier egressAclId, IsMonitoringEnabled? isMonitoringEnabled, BgpConfiguration bgpConfiguration, StaticRouteConfiguration staticRouteConfiguration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Annotation = annotation;
            Mtu = mtu;
            ConnectedIPv4Subnets = connectedIPv4Subnets;
            ConnectedIPv6Subnets = connectedIPv6Subnets;
            ImportRoutePolicyId = importRoutePolicyId;
            ExportRoutePolicyId = exportRoutePolicyId;
            ImportRoutePolicy = importRoutePolicy;
            ExportRoutePolicy = exportRoutePolicy;
            IngressAclId = ingressAclId;
            EgressAclId = egressAclId;
            IsMonitoringEnabled = isMonitoringEnabled;
            BgpConfiguration = bgpConfiguration;
            StaticRouteConfiguration = staticRouteConfiguration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> Maximum transmission unit. Default value is 1500. </summary>
        public int? Mtu { get; set; }
        /// <summary> List of Connected IPv4 Subnets. </summary>
        public IList<ConnectedSubnet> ConnectedIPv4Subnets { get; }
        /// <summary> List of connected IPv6 Subnets. </summary>
        public IList<ConnectedSubnet> ConnectedIPv6Subnets { get; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ImportRoutePolicyId { get; set; }
        /// <summary> ARM Resource ID of the RoutePolicy. This is used for the backward compatibility. </summary>
        public ResourceIdentifier ExportRoutePolicyId { get; set; }
        /// <summary> Import Route Policy either IPv4 or IPv6. </summary>
        public ImportRoutePolicy ImportRoutePolicy { get; set; }
        /// <summary> Export Route Policy either IPv4 or IPv6. </summary>
        public ExportRoutePolicy ExportRoutePolicy { get; set; }
        /// <summary> Ingress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier IngressAclId { get; set; }
        /// <summary> Egress Acl. ARM resource ID of Access Control Lists. </summary>
        public ResourceIdentifier EgressAclId { get; set; }
        /// <summary> To check whether monitoring of internal network is enabled or not. </summary>
        public IsMonitoringEnabled? IsMonitoringEnabled { get; set; }
        /// <summary> BGP configuration properties. </summary>
        public BgpConfiguration BgpConfiguration { get; set; }
        /// <summary> Static Route Configuration properties. </summary>
        public StaticRouteConfiguration StaticRouteConfiguration { get; set; }
    }
}
