// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.Communication.ChatThreadPropertiesUpdated event. </summary>
    public partial class AcsChatThreadPropertiesUpdatedEventData : AcsChatThreadEventInThreadBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="AcsChatThreadPropertiesUpdatedEventData"/>. </summary>
        internal AcsChatThreadPropertiesUpdatedEventData()
        {
            Properties = new ChangeTrackingDictionary<string, object>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="AcsChatThreadPropertiesUpdatedEventData"/>. </summary>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="editedByCommunicationIdentifier"> The communication identifier of the user who updated the thread properties. </param>
        /// <param name="editTime"> The time at which the properties of the thread were updated. </param>
        /// <param name="properties"> The updated thread properties. </param>
        /// <param name="metadata"> The thread metadata. </param>
        internal AcsChatThreadPropertiesUpdatedEventData(string transactionId, string threadId, DateTimeOffset? createTime, long? version, CommunicationIdentifierModel editedByCommunicationIdentifier, DateTimeOffset? editTime, IReadOnlyDictionary<string, object> properties, IReadOnlyDictionary<string, string> metadata) : base(transactionId, threadId, createTime, version)
        {
            EditedByCommunicationIdentifier = editedByCommunicationIdentifier;
            EditTime = editTime;
            Properties = properties;
            Metadata = metadata;
        }

        /// <summary> The communication identifier of the user who updated the thread properties. </summary>
        public CommunicationIdentifierModel EditedByCommunicationIdentifier { get; }
        /// <summary> The time at which the properties of the thread were updated. </summary>
        public DateTimeOffset? EditTime { get; }
        /// <summary> The updated thread properties. </summary>
        public IReadOnlyDictionary<string, object> Properties { get; }
        /// <summary> The thread metadata. </summary>
        public IReadOnlyDictionary<string, string> Metadata { get; }
    }
}
