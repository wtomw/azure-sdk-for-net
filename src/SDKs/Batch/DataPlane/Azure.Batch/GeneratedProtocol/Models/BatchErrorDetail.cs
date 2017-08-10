// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// An item of additional information included in an Azure Batch error
    /// response.
    /// </summary>
    public partial class BatchErrorDetail
    {
        /// <summary>
        /// Initializes a new instance of the BatchErrorDetail class.
        /// </summary>
        public BatchErrorDetail() { }

        /// <summary>
        /// Initializes a new instance of the BatchErrorDetail class.
        /// </summary>
        /// <param name="key">An identifier specifying the meaning of the Value
        /// property.</param>
        /// <param name="value">The additional information included with the
        /// error response.</param>
        public BatchErrorDetail(string key = default(string), string value = default(string))
        {
            this.Key = key;
            this.Value = value;
        }

        /// <summary>
        /// Gets or sets an identifier specifying the meaning of the Value
        /// property.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "key")]
        public string Key { get; set; }

        /// <summary>
        /// Gets or sets the additional information included with the error
        /// response.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

    }
}