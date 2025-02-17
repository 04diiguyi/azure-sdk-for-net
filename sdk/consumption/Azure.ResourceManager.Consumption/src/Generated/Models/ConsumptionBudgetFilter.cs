// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.Consumption;

namespace Azure.ResourceManager.Consumption.Models
{
    /// <summary> May be used to filter budgets by resource group, resource, or meter. </summary>
    public partial class ConsumptionBudgetFilter
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

        /// <summary> Initializes a new instance of <see cref="ConsumptionBudgetFilter"/>. </summary>
        public ConsumptionBudgetFilter()
        {
            And = new ChangeTrackingList<BudgetFilterProperties>();
        }

        /// <summary> Initializes a new instance of <see cref="ConsumptionBudgetFilter"/>. </summary>
        /// <param name="and"> The logical "AND" expression. Must have at least 2 items. </param>
        /// <param name="dimensions"> Has comparison expression for a dimension. </param>
        /// <param name="tags"> Has comparison expression for a tag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConsumptionBudgetFilter(IList<BudgetFilterProperties> and, BudgetComparisonExpression dimensions, BudgetComparisonExpression tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            And = and;
            Dimensions = dimensions;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The logical "AND" expression. Must have at least 2 items. </summary>
        public IList<BudgetFilterProperties> And { get; }
        /// <summary> Has comparison expression for a dimension. </summary>
        public BudgetComparisonExpression Dimensions { get; set; }
        /// <summary> Has comparison expression for a tag. </summary>
        public BudgetComparisonExpression Tags { get; set; }
    }
}
