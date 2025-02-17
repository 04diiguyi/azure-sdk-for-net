// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Script block of scripts. </summary>
    public partial class ScriptActivityScriptBlock
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

        /// <summary> Initializes a new instance of <see cref="ScriptActivityScriptBlock"/>. </summary>
        /// <param name="text"> The query text. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptType"> The type of the query. Type: string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> is null. </exception>
        public ScriptActivityScriptBlock(DataFactoryElement<string> text, DataFactoryScriptType scriptType)
        {
            Argument.AssertNotNull(text, nameof(text));

            Text = text;
            ScriptType = scriptType;
            Parameters = new ChangeTrackingList<ScriptActivityParameter>();
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActivityScriptBlock"/>. </summary>
        /// <param name="text"> The query text. Type: string (or Expression with resultType string). </param>
        /// <param name="scriptType"> The type of the query. Type: string. </param>
        /// <param name="parameters"> Array of script parameters. Type: array. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptActivityScriptBlock(DataFactoryElement<string> text, DataFactoryScriptType scriptType, IList<ScriptActivityParameter> parameters, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Text = text;
            ScriptType = scriptType;
            Parameters = parameters;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ScriptActivityScriptBlock"/> for deserialization. </summary>
        internal ScriptActivityScriptBlock()
        {
        }

        /// <summary> The query text. Type: string (or Expression with resultType string). </summary>
        public DataFactoryElement<string> Text { get; set; }
        /// <summary> The type of the query. Type: string. </summary>
        public DataFactoryScriptType ScriptType { get; set; }
        /// <summary> Array of script parameters. Type: array. </summary>
        public IList<ScriptActivityParameter> Parameters { get; }
    }
}
