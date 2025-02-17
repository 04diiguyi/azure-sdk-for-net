// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Ldap authentication method properties. This feature is in preview. </summary>
    public partial class AuthenticationMethodLdapProperties
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

        /// <summary> Initializes a new instance of <see cref="AuthenticationMethodLdapProperties"/>. </summary>
        public AuthenticationMethodLdapProperties()
        {
            ServerCertificates = new ChangeTrackingList<CassandraCertificate>();
        }

        /// <summary> Initializes a new instance of <see cref="AuthenticationMethodLdapProperties"/>. </summary>
        /// <param name="serverHostname"> Hostname of the LDAP server. </param>
        /// <param name="serverPort"> Port of the LDAP server. </param>
        /// <param name="serviceUserDistinguishedName"> Distinguished name of the look up user account, who can look up user details on authentication. </param>
        /// <param name="serviceUserPassword"> Password of the look up user. </param>
        /// <param name="searchBaseDistinguishedName"> Distinguished name of the object to start the recursive search of users from. </param>
        /// <param name="searchFilterTemplate"> Template to use for searching. Defaults to (cn=%s) where %s will be replaced by the username used to login. </param>
        /// <param name="serverCertificates"></param>
        /// <param name="connectionTimeoutInMs"> Timeout for connecting to the LDAP server in miliseconds. The default is 5000 ms. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AuthenticationMethodLdapProperties(string serverHostname, int? serverPort, string serviceUserDistinguishedName, string serviceUserPassword, string searchBaseDistinguishedName, string searchFilterTemplate, IList<CassandraCertificate> serverCertificates, int? connectionTimeoutInMs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ServerHostname = serverHostname;
            ServerPort = serverPort;
            ServiceUserDistinguishedName = serviceUserDistinguishedName;
            ServiceUserPassword = serviceUserPassword;
            SearchBaseDistinguishedName = searchBaseDistinguishedName;
            SearchFilterTemplate = searchFilterTemplate;
            ServerCertificates = serverCertificates;
            ConnectionTimeoutInMs = connectionTimeoutInMs;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Hostname of the LDAP server. </summary>
        public string ServerHostname { get; set; }
        /// <summary> Port of the LDAP server. </summary>
        public int? ServerPort { get; set; }
        /// <summary> Distinguished name of the look up user account, who can look up user details on authentication. </summary>
        public string ServiceUserDistinguishedName { get; set; }
        /// <summary> Password of the look up user. </summary>
        public string ServiceUserPassword { get; set; }
        /// <summary> Distinguished name of the object to start the recursive search of users from. </summary>
        public string SearchBaseDistinguishedName { get; set; }
        /// <summary> Template to use for searching. Defaults to (cn=%s) where %s will be replaced by the username used to login. </summary>
        public string SearchFilterTemplate { get; set; }
        /// <summary> Gets the server certificates. </summary>
        public IList<CassandraCertificate> ServerCertificates { get; }
        /// <summary> Timeout for connecting to the LDAP server in miliseconds. The default is 5000 ms. </summary>
        public int? ConnectionTimeoutInMs { get; set; }
    }
}
