// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary>
    /// The parameters used to add a new Azure Storage account while creating a new Data Lake Analytics account.
    /// Serialized Name: AddStorageAccountWithAccountParameters
    /// </summary>
    public partial class StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the Azure Storage account to add.
        /// Serialized Name: AddStorageAccountWithAccountParameters.name
        /// </param>
        /// <param name="accessKey">
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.accessKey
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="accessKey"/> is null. </exception>
        public StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent(string name, string accessKey)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(accessKey, nameof(accessKey));

            Name = name;
            AccessKey = accessKey;
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent"/>. </summary>
        /// <param name="name">
        /// The unique name of the Azure Storage account to add.
        /// Serialized Name: AddStorageAccountWithAccountParameters.name
        /// </param>
        /// <param name="accessKey">
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.accessKey
        /// </param>
        /// <param name="suffix">
        /// The optional suffix for the storage account.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.suffix
        /// </param>
        internal StorageAccountForDataLakeAnalyticsAccountCreateOrUpdateContent(string name, string accessKey, string suffix)
        {
            Name = name;
            AccessKey = accessKey;
            Suffix = suffix;
        }

        /// <summary>
        /// The unique name of the Azure Storage account to add.
        /// Serialized Name: AddStorageAccountWithAccountParameters.name
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// The access key associated with this Azure Storage account that will be used to connect to it.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.accessKey
        /// </summary>
        public string AccessKey { get; }
        /// <summary>
        /// The optional suffix for the storage account.
        /// Serialized Name: AddStorageAccountWithAccountParameters.properties.suffix
        /// </summary>
        public string Suffix { get; set; }
    }
}
