// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Health.Insights.RadiologyInsights
{
    /// <summary>
    /// A ratio of two Quantity values - a numerator and a denominator
    /// Based on [FHIR Ratio](https://www.hl7.org/fhir/R4/datatypes.html#Ratio)
    /// </summary>
    public partial class FhirR4Ratio : FhirR4Element
    {
        /// <summary> Initializes a new instance of <see cref="FhirR4Ratio"/>. </summary>
        public FhirR4Ratio()
        {
        }

        /// <summary> Initializes a new instance of <see cref="FhirR4Ratio"/>. </summary>
        /// <param name="id"> Unique id for inter-element referencing. </param>
        /// <param name="extension"> Additional Content defined by implementations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="numerator"> Numerator value. </param>
        /// <param name="denominator"> Denominator value. </param>
        internal FhirR4Ratio(string id, IReadOnlyList<FhirR4Extension> extension, IDictionary<string, BinaryData> serializedAdditionalRawData, FhirR4Quantity numerator, FhirR4Quantity denominator) : base(id, extension, serializedAdditionalRawData)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        /// <summary> Numerator value. </summary>
        public FhirR4Quantity Numerator { get; set; }
        /// <summary> Denominator value. </summary>
        public FhirR4Quantity Denominator { get; set; }
    }
}
