// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Information about a token returned by an analyzer.
    /// </summary>
    public partial class TokenInfo
    {
        /// <summary>
        /// Initializes a new instance of the TokenInfo class.
        /// </summary>
        public TokenInfo() { }

        /// <summary>
        /// Initializes a new instance of the TokenInfo class.
        /// </summary>
        public TokenInfo(string token = default(string), int? startOffset = default(int?), int? endOffset = default(int?), int? position = default(int?))
        {
            Token = token;
            StartOffset = startOffset;
            EndOffset = endOffset;
            Position = position;
        }

        /// <summary>
        /// Gets the token returned by the analyzer.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string Token { get; private set; }

        /// <summary>
        /// Gets the index of the first character of the token in the input
        /// text.
        /// </summary>
        [JsonProperty(PropertyName = "startOffset")]
        public int? StartOffset { get; private set; }

        /// <summary>
        /// Gets the index of the last character of the token in the input
        /// text.
        /// </summary>
        [JsonProperty(PropertyName = "endOffset")]
        public int? EndOffset { get; private set; }

        /// <summary>
        /// Gets the position of the token in the input text relative to other
        /// tokens. The first token in the input text has position 0, the
        /// next has position 1, and so on. Depending on the analyzer used,
        /// some tokens might have the same position, for example if they are
        /// synonyms of each other.
        /// </summary>
        [JsonProperty(PropertyName = "position")]
        public int? Position { get; private set; }

    }
}