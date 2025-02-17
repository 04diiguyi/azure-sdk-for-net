// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.IoT.Hub.Service;

namespace Azure.IoT.Hub.Service.Models
{
    /// <summary> The ConfigurationQueriesTestResponse. </summary>
    public partial class ConfigurationQueriesTestResponse
    {
        /// <summary> Initializes a new instance of <see cref="ConfigurationQueriesTestResponse"/>. </summary>
        internal ConfigurationQueriesTestResponse()
        {
            CustomMetricQueryErrors = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ConfigurationQueriesTestResponse"/>. </summary>
        /// <param name="targetConditionError"> The errors from running the target condition query. </param>
        /// <param name="customMetricQueryErrors"> The errors from running the custom metric query. </param>
        internal ConfigurationQueriesTestResponse(string targetConditionError, IReadOnlyDictionary<string, string> customMetricQueryErrors)
        {
            TargetConditionError = targetConditionError;
            CustomMetricQueryErrors = customMetricQueryErrors;
        }

        /// <summary> The errors from running the target condition query. </summary>
        public string TargetConditionError { get; }
        /// <summary> The errors from running the custom metric query. </summary>
        public IReadOnlyDictionary<string, string> CustomMetricQueryErrors { get; }
    }
}
