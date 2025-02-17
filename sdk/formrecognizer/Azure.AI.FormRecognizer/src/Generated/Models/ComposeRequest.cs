// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.FormRecognizer;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Request contract for compose operation. </summary>
    internal partial class ComposeRequest
    {
        /// <summary> Initializes a new instance of <see cref="ComposeRequest"/>. </summary>
        /// <param name="modelIds"> List of model ids to compose. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelIds"/> is null. </exception>
        public ComposeRequest(IEnumerable<Guid> modelIds)
        {
            Argument.AssertNotNull(modelIds, nameof(modelIds));

            ModelIds = modelIds.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="ComposeRequest"/>. </summary>
        /// <param name="modelIds"> List of model ids to compose. </param>
        /// <param name="modelName"> Optional user defined model name (max length: 1024). </param>
        internal ComposeRequest(IList<Guid> modelIds, string modelName)
        {
            ModelIds = modelIds;
            ModelName = modelName;
        }

        /// <summary> List of model ids to compose. </summary>
        public IList<Guid> ModelIds { get; }
        /// <summary> Optional user defined model name (max length: 1024). </summary>
        public string ModelName { get; set; }
    }
}
