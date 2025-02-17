// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataProtectionBackup;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Azure backup restore request
    /// Please note <see cref="BackupRestoreContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="BackupRecoveryPointBasedRestoreContent"/>, <see cref="BackupRecoveryTimeBasedRestoreContent"/> and <see cref="BackupRestoreWithRehydrationContent"/>.
    /// </summary>
    public abstract partial class BackupRestoreContent
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
        private protected IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="BackupRestoreContent"/>. </summary>
        /// <param name="restoreTargetInfo">
        /// Gets or sets the restore target information.
        /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="Models.RestoreTargetInfo"/>.
        /// </param>
        /// <param name="sourceDataStoreType"> Gets or sets the type of the source data store. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="restoreTargetInfo"/> is null. </exception>
        protected BackupRestoreContent(RestoreTargetInfoBase restoreTargetInfo, SourceDataStoreType sourceDataStoreType)
        {
            Argument.AssertNotNull(restoreTargetInfo, nameof(restoreTargetInfo));

            RestoreTargetInfo = restoreTargetInfo;
            SourceDataStoreType = sourceDataStoreType;
        }

        /// <summary> Initializes a new instance of <see cref="BackupRestoreContent"/>. </summary>
        /// <param name="objectType"></param>
        /// <param name="restoreTargetInfo">
        /// Gets or sets the restore target information.
        /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="Models.RestoreTargetInfo"/>.
        /// </param>
        /// <param name="sourceDataStoreType"> Gets or sets the type of the source data store. </param>
        /// <param name="sourceResourceId"> Fully qualified Azure Resource Manager ID of the datasource which is being recovered. </param>
        /// <param name="identityDetails">
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupRestoreContent(string objectType, RestoreTargetInfoBase restoreTargetInfo, SourceDataStoreType sourceDataStoreType, ResourceIdentifier sourceResourceId, DataProtectionIdentityDetails identityDetails, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ObjectType = objectType;
            RestoreTargetInfo = restoreTargetInfo;
            SourceDataStoreType = sourceDataStoreType;
            SourceResourceId = sourceResourceId;
            IdentityDetails = identityDetails;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="BackupRestoreContent"/> for deserialization. </summary>
        internal BackupRestoreContent()
        {
        }

        /// <summary> Gets or sets the object type. </summary>
        internal string ObjectType { get; set; }
        /// <summary>
        /// Gets or sets the restore target information.
        /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="Models.RestoreTargetInfo"/>.
        /// </summary>
        public RestoreTargetInfoBase RestoreTargetInfo { get; }
        /// <summary> Gets or sets the type of the source data store. </summary>
        public SourceDataStoreType SourceDataStoreType { get; }
        /// <summary> Fully qualified Azure Resource Manager ID of the datasource which is being recovered. </summary>
        public ResourceIdentifier SourceResourceId { get; set; }
        /// <summary>
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </summary>
        public DataProtectionIdentityDetails IdentityDetails { get; set; }
    }
}
