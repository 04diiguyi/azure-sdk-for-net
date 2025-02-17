// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.EventGrid;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Information about the event hub destination for an event subscription. </summary>
    public partial class EventHubEventSubscriptionDestination : EventSubscriptionDestination
    {
        /// <summary> Initializes a new instance of <see cref="EventHubEventSubscriptionDestination"/>. </summary>
        public EventHubEventSubscriptionDestination()
        {
            DeliveryAttributeMappings = new ChangeTrackingList<DeliveryAttributeMapping>();
            EndpointType = EndpointType.EventHub;
        }

        /// <summary> Initializes a new instance of <see cref="EventHubEventSubscriptionDestination"/>. </summary>
        /// <param name="endpointType"> Type of the endpoint for the event subscription destination. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="resourceId"> The Azure Resource Id that represents the endpoint of an Event Hub destination of an event subscription. </param>
        /// <param name="deliveryAttributeMappings">
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </param>
        internal EventHubEventSubscriptionDestination(EndpointType endpointType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier resourceId, IList<DeliveryAttributeMapping> deliveryAttributeMappings) : base(endpointType, serializedAdditionalRawData)
        {
            ResourceId = resourceId;
            DeliveryAttributeMappings = deliveryAttributeMappings;
            EndpointType = endpointType;
        }

        /// <summary> The Azure Resource Id that represents the endpoint of an Event Hub destination of an event subscription. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary>
        /// Delivery attribute details.
        /// Please note <see cref="DeliveryAttributeMapping"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DynamicDeliveryAttributeMapping"/> and <see cref="StaticDeliveryAttributeMapping"/>.
        /// </summary>
        public IList<DeliveryAttributeMapping> DeliveryAttributeMappings { get; }
    }
}
