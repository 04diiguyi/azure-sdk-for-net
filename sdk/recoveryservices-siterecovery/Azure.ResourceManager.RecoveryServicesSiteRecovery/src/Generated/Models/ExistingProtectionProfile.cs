// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.RecoveryServicesSiteRecovery;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Existing storage account input. </summary>
    public partial class ExistingProtectionProfile : ProtectionProfileCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="ExistingProtectionProfile"/>. </summary>
        /// <param name="protectionProfileId"> The protection profile Arm Id. Throw error, if resource does not exists. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="protectionProfileId"/> is null. </exception>
        public ExistingProtectionProfile(string protectionProfileId)
        {
            Argument.AssertNotNull(protectionProfileId, nameof(protectionProfileId));

            ProtectionProfileId = protectionProfileId;
            ResourceType = "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingProtectionProfile"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="protectionProfileId"> The protection profile Arm Id. Throw error, if resource does not exists. </param>
        internal ExistingProtectionProfile(string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, string protectionProfileId) : base(resourceType, serializedAdditionalRawData)
        {
            ProtectionProfileId = protectionProfileId;
            ResourceType = resourceType ?? "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingProtectionProfile"/> for deserialization. </summary>
        internal ExistingProtectionProfile()
        {
        }

        /// <summary> The protection profile Arm Id. Throw error, if resource does not exists. </summary>
        public string ProtectionProfileId { get; set; }
    }
}
