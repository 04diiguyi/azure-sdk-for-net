// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> The request that is made for a long term retention backup. </summary>
    public partial class PostgreSqlFlexibleServerLtrBackupContent : PostgreSqlBackupContent
    {
        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLtrBackupContent"/>. </summary>
        /// <param name="backupSettings"> Backup Settings. </param>
        /// <param name="targetDetails"> Backup store detail for target server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="backupSettings"/> or <paramref name="targetDetails"/> is null. </exception>
        public PostgreSqlFlexibleServerLtrBackupContent(PostgreSqlFlexibleServerBackupSettings backupSettings, PostgreSqlFlexibleServerBackupStoreDetails targetDetails) : base(backupSettings)
        {
            Argument.AssertNotNull(backupSettings, nameof(backupSettings));
            Argument.AssertNotNull(targetDetails, nameof(targetDetails));

            TargetDetails = targetDetails;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLtrBackupContent"/>. </summary>
        /// <param name="backupSettings"> Backup Settings. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="targetDetails"> Backup store detail for target server. </param>
        internal PostgreSqlFlexibleServerLtrBackupContent(PostgreSqlFlexibleServerBackupSettings backupSettings, IDictionary<string, BinaryData> serializedAdditionalRawData, PostgreSqlFlexibleServerBackupStoreDetails targetDetails) : base(backupSettings, serializedAdditionalRawData)
        {
            TargetDetails = targetDetails;
        }

        /// <summary> Initializes a new instance of <see cref="PostgreSqlFlexibleServerLtrBackupContent"/> for deserialization. </summary>
        internal PostgreSqlFlexibleServerLtrBackupContent()
        {
        }

        /// <summary> Backup store detail for target server. </summary>
        internal PostgreSqlFlexibleServerBackupStoreDetails TargetDetails { get; }
        /// <summary> List of SAS uri of storage containers where backup data is to be streamed/copied. </summary>
        public IList<string> TargetDetailsSasUriList
        {
            get => TargetDetails?.SasUriList;
        }
    }
}
