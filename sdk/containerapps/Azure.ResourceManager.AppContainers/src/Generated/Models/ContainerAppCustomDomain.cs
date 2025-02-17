// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Custom Domain of a Container App. </summary>
    public partial class ContainerAppCustomDomain
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

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomain"/>. </summary>
        /// <param name="name"> Hostname. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public ContainerAppCustomDomain(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomain"/>. </summary>
        /// <param name="name"> Hostname. </param>
        /// <param name="bindingType"> Custom Domain binding type. </param>
        /// <param name="certificateId"> Resource Id of the Certificate to be bound to this hostname. Must exist in the Managed Environment. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerAppCustomDomain(string name, ContainerAppCustomDomainBindingType? bindingType, ResourceIdentifier certificateId, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            BindingType = bindingType;
            CertificateId = certificateId;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerAppCustomDomain"/> for deserialization. </summary>
        internal ContainerAppCustomDomain()
        {
        }

        /// <summary> Hostname. </summary>
        public string Name { get; set; }
        /// <summary> Custom Domain binding type. </summary>
        public ContainerAppCustomDomainBindingType? BindingType { get; set; }
        /// <summary> Resource Id of the Certificate to be bound to this hostname. Must exist in the Managed Environment. </summary>
        public ResourceIdentifier CertificateId { get; set; }
    }
}
