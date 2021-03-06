// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The storage account update parameters.
    /// </summary>
    public partial class StorageAccountUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        public StorageAccountUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StorageAccountUpdateParameters
        /// class.
        /// </summary>
        /// <param name="activeKeyName">The current active storage account key
        /// name.</param>
        /// <param name="autoRegenerateKey">whether keyvault should manage the
        /// storage account for the user.</param>
        /// <param name="regenerationPeriod">The key regeneration time duration
        /// specified in ISO-8601 format.</param>
        /// <param name="storageAccountAttributes">The attributes of the
        /// storage account.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        public StorageAccountUpdateParameters(string activeKeyName = default(string), bool? autoRegenerateKey = default(bool?), string regenerationPeriod = default(string), StorageAccountAttributes storageAccountAttributes = default(StorageAccountAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            ActiveKeyName = activeKeyName;
            AutoRegenerateKey = autoRegenerateKey;
            RegenerationPeriod = regenerationPeriod;
            StorageAccountAttributes = storageAccountAttributes;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the current active storage account key name.
        /// </summary>
        [JsonProperty(PropertyName = "activeKeyName")]
        public string ActiveKeyName { get; set; }

        /// <summary>
        /// Gets or sets whether keyvault should manage the storage account for
        /// the user.
        /// </summary>
        [JsonProperty(PropertyName = "autoRegenerateKey")]
        public bool? AutoRegenerateKey { get; set; }

        /// <summary>
        /// Gets or sets the key regeneration time duration specified in
        /// ISO-8601 format.
        /// </summary>
        [JsonProperty(PropertyName = "regenerationPeriod")]
        public string RegenerationPeriod { get; set; }

        /// <summary>
        /// Gets or sets the attributes of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public StorageAccountAttributes StorageAccountAttributes { get; set; }

        /// <summary>
        /// Gets or sets application specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
