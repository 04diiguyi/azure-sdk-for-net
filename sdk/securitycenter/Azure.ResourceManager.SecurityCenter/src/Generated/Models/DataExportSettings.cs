// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents a data export setting. </summary>
    public partial class DataExportSettings : SecuritySettingData
    {
        /// <summary> Initializes a new instance of <see cref="DataExportSettings"/>. </summary>
        public DataExportSettings()
        {
            Kind = SettingKind.DataExportSettings;
        }

        /// <summary> Initializes a new instance of <see cref="DataExportSettings"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> the kind of the settings string. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="isEnabled"> Is the data export setting enabled. </param>
        internal DataExportSettings(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SettingKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? isEnabled) : base(id, name, resourceType, systemData, kind, serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Kind = kind;
        }

        /// <summary> Is the data export setting enabled. </summary>
        public bool? IsEnabled { get; set; }
    }
}
