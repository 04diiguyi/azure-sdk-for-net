// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Storage
{
    /// <summary>
    /// A class representing the DeletedAccount data model.
    /// Deleted storage account
    /// </summary>
    public partial class DeletedAccountData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="DeletedAccountData"/>. </summary>
        public DeletedAccountData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DeletedAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="storageAccountResourceId"> Full resource id of the original storage account. </param>
        /// <param name="location"> Location of the deleted account. </param>
        /// <param name="restoreReference"> Can be used to attempt recovering this deleted account via PutStorageAccount API. </param>
        /// <param name="createdOn"> Creation time of the deleted account. </param>
        /// <param name="deletedOn"> Deletion time of the deleted account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DeletedAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier storageAccountResourceId, AzureLocation? location, string restoreReference, DateTimeOffset? createdOn, DateTimeOffset? deletedOn, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            StorageAccountResourceId = storageAccountResourceId;
            Location = location;
            RestoreReference = restoreReference;
            CreatedOn = createdOn;
            DeletedOn = deletedOn;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Full resource id of the original storage account. </summary>
        public ResourceIdentifier StorageAccountResourceId { get; }
        /// <summary> Location of the deleted account. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Can be used to attempt recovering this deleted account via PutStorageAccount API. </summary>
        public string RestoreReference { get; }
        /// <summary> Creation time of the deleted account. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Deletion time of the deleted account. </summary>
        public DateTimeOffset? DeletedOn { get; }
    }
}
