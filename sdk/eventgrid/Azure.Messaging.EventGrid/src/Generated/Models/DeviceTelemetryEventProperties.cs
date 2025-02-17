// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for a device telemetry event (DeviceTelemetry). </summary>
    public partial class DeviceTelemetryEventProperties
    {
        /// <summary> Initializes a new instance of <see cref="DeviceTelemetryEventProperties"/>. </summary>
        internal DeviceTelemetryEventProperties()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            SystemProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DeviceTelemetryEventProperties"/>. </summary>
        /// <param name="body"> The content of the message from the device. </param>
        /// <param name="properties"> Application properties are user-defined strings that can be added to the message. These fields are optional. </param>
        /// <param name="systemProperties"> System properties help identify contents and source of the messages. </param>
        internal DeviceTelemetryEventProperties(object body, IReadOnlyDictionary<string, string> properties, IReadOnlyDictionary<string, string> systemProperties)
        {
            Body = body;
            Properties = properties;
            SystemProperties = systemProperties;
        }

        /// <summary> The content of the message from the device. </summary>
        public object Body { get; }
        /// <summary> Application properties are user-defined strings that can be added to the message. These fields are optional. </summary>
        public IReadOnlyDictionary<string, string> Properties { get; }
        /// <summary> System properties help identify contents and source of the messages. </summary>
        public IReadOnlyDictionary<string, string> SystemProperties { get; }
    }
}
