// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The name of usage.
    /// </summary>
    public partial class NameInfo
    {
        /// <summary>
        /// Initializes a new instance of the NameInfo class.
        /// </summary>
        public NameInfo()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NameInfo class.
        /// </summary>
        /// <param name="value">Value of usage.</param>
        /// <param name="localizedValue">Localized value of usage.</param>
        public NameInfo(string value = default(string), string localizedValue = default(string))
        {
            Value = value;
            LocalizedValue = localizedValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets value of usage.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets localized value of usage.
        /// </summary>
        [JsonProperty(PropertyName = "localizedValue")]
        public string LocalizedValue { get; set; }

    }
}