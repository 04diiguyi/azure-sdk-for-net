// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of an Azure SQL Database sync group log. </summary>
    public partial class SyncGroupLogProperties
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

        /// <summary> Initializes a new instance of <see cref="SyncGroupLogProperties"/>. </summary>
        internal SyncGroupLogProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SyncGroupLogProperties"/>. </summary>
        /// <param name="timestamp"> Timestamp of the sync group log. </param>
        /// <param name="logType"> Type of the sync group log. </param>
        /// <param name="source"> Source of the sync group log. </param>
        /// <param name="details"> Details of the sync group log. </param>
        /// <param name="tracingId"> TracingId of the sync group log. </param>
        /// <param name="operationStatus"> OperationStatus of the sync group log. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SyncGroupLogProperties(DateTimeOffset? timestamp, SyncGroupLogType? logType, string source, string details, Guid? tracingId, string operationStatus, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Timestamp = timestamp;
            LogType = logType;
            Source = source;
            Details = details;
            TracingId = tracingId;
            OperationStatus = operationStatus;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Timestamp of the sync group log. </summary>
        public DateTimeOffset? Timestamp { get; }
        /// <summary> Type of the sync group log. </summary>
        public SyncGroupLogType? LogType { get; }
        /// <summary> Source of the sync group log. </summary>
        public string Source { get; }
        /// <summary> Details of the sync group log. </summary>
        public string Details { get; }
        /// <summary> TracingId of the sync group log. </summary>
        public Guid? TracingId { get; }
        /// <summary> OperationStatus of the sync group log. </summary>
        public string OperationStatus { get; }
    }
}
