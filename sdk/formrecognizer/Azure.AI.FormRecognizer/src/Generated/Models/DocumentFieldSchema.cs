// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.FormRecognizer;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Description of the field semantic schema using a JSON Schema style syntax. </summary>
    public partial class DocumentFieldSchema
    {
        /// <summary> Initializes a new instance of <see cref="DocumentFieldSchema"/>. </summary>
        /// <param name="type"> Semantic data type of the field value. </param>
        internal DocumentFieldSchema(DocumentFieldType type)
        {
            Type = type;
            Properties = new ChangeTrackingDictionary<string, DocumentFieldSchema>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentFieldSchema"/>. </summary>
        /// <param name="type"> Semantic data type of the field value. </param>
        /// <param name="description"> Field description. </param>
        /// <param name="example"> Example field content. </param>
        /// <param name="items"> Field type schema of each array element. </param>
        /// <param name="properties"> Named sub-fields of the object field. </param>
        internal DocumentFieldSchema(DocumentFieldType type, string description, string example, DocumentFieldSchema items, IReadOnlyDictionary<string, DocumentFieldSchema> properties)
        {
            Type = type;
            Description = description;
            Example = example;
            Items = items;
            Properties = properties;
        }

        /// <summary> Semantic data type of the field value. </summary>
        public DocumentFieldType Type { get; }
        /// <summary> Field description. </summary>
        public string Description { get; }
        /// <summary> Example field content. </summary>
        public string Example { get; }
        /// <summary> Field type schema of each array element. </summary>
        public DocumentFieldSchema Items { get; }
        /// <summary> Named sub-fields of the object field. </summary>
        public IReadOnlyDictionary<string, DocumentFieldSchema> Properties { get; }
    }
}
