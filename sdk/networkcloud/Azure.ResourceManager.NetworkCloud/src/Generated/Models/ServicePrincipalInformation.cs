// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> ServicePrincipalInformation represents the details of the service principal to be used by the cluster during Arc Appliance installation. </summary>
    public partial class ServicePrincipalInformation
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

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInformation"/>. </summary>
        /// <param name="applicationId"> The application ID, also known as client ID, of the service principal. </param>
        /// <param name="principalId"> The principal ID, also known as the object ID, of the service principal. </param>
        /// <param name="tenantId"> The tenant ID, also known as the directory ID, of the tenant in which the service principal is created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationId"/>, <paramref name="principalId"/> or <paramref name="tenantId"/> is null. </exception>
        public ServicePrincipalInformation(string applicationId, string principalId, string tenantId)
        {
            Argument.AssertNotNull(applicationId, nameof(applicationId));
            Argument.AssertNotNull(principalId, nameof(principalId));
            Argument.AssertNotNull(tenantId, nameof(tenantId));

            ApplicationId = applicationId;
            PrincipalId = principalId;
            TenantId = tenantId;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInformation"/>. </summary>
        /// <param name="applicationId"> The application ID, also known as client ID, of the service principal. </param>
        /// <param name="password"> The password of the service principal. </param>
        /// <param name="principalId"> The principal ID, also known as the object ID, of the service principal. </param>
        /// <param name="tenantId"> The tenant ID, also known as the directory ID, of the tenant in which the service principal is created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ServicePrincipalInformation(string applicationId, string password, string principalId, string tenantId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApplicationId = applicationId;
            Password = password;
            PrincipalId = principalId;
            TenantId = tenantId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ServicePrincipalInformation"/> for deserialization. </summary>
        internal ServicePrincipalInformation()
        {
        }

        /// <summary> The application ID, also known as client ID, of the service principal. </summary>
        public string ApplicationId { get; set; }
        /// <summary> The password of the service principal. </summary>
        public string Password { get; set; }
        /// <summary> The principal ID, also known as the object ID, of the service principal. </summary>
        public string PrincipalId { get; set; }
        /// <summary> The tenant ID, also known as the directory ID, of the tenant in which the service principal is created. </summary>
        public string TenantId { get; set; }
    }
}
