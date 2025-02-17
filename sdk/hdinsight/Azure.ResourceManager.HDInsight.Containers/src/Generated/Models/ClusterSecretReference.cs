// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Secret reference and corresponding properties of a key vault secret. </summary>
    public partial class ClusterSecretReference
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

        /// <summary> Initializes a new instance of <see cref="ClusterSecretReference"/>. </summary>
        /// <param name="referenceName"> Reference name of the secret to be used in service configs. </param>
        /// <param name="keyVaultObjectType"> Type of key vault object: secret, key or certificate. </param>
        /// <param name="keyVaultObjectName"> Object identifier name of the secret in key vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> or <paramref name="keyVaultObjectName"/> is null. </exception>
        public ClusterSecretReference(string referenceName, KeyVaultObjectType keyVaultObjectType, string keyVaultObjectName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));
            Argument.AssertNotNull(keyVaultObjectName, nameof(keyVaultObjectName));

            ReferenceName = referenceName;
            KeyVaultObjectType = keyVaultObjectType;
            KeyVaultObjectName = keyVaultObjectName;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterSecretReference"/>. </summary>
        /// <param name="referenceName"> Reference name of the secret to be used in service configs. </param>
        /// <param name="keyVaultObjectType"> Type of key vault object: secret, key or certificate. </param>
        /// <param name="version"> Version of the secret in key vault. </param>
        /// <param name="keyVaultObjectName"> Object identifier name of the secret in key vault. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterSecretReference(string referenceName, KeyVaultObjectType keyVaultObjectType, string version, string keyVaultObjectName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReferenceName = referenceName;
            KeyVaultObjectType = keyVaultObjectType;
            Version = version;
            KeyVaultObjectName = keyVaultObjectName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterSecretReference"/> for deserialization. </summary>
        internal ClusterSecretReference()
        {
        }

        /// <summary> Reference name of the secret to be used in service configs. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Type of key vault object: secret, key or certificate. </summary>
        public KeyVaultObjectType KeyVaultObjectType { get; set; }
        /// <summary> Version of the secret in key vault. </summary>
        public string Version { get; set; }
        /// <summary> Object identifier name of the secret in key vault. </summary>
        public string KeyVaultObjectName { get; set; }
    }
}
