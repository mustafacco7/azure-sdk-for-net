// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Factory's GitHub repo information. </summary>
    public partial class FactoryGitHubConfiguration : FactoryRepoConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="FactoryGitHubConfiguration"/>. </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="accountName"/>, <paramref name="repositoryName"/>, <paramref name="collaborationBranch"/> or <paramref name="rootFolder"/> is null. </exception>
        public FactoryGitHubConfiguration(string accountName, string repositoryName, string collaborationBranch, string rootFolder) : base(accountName, repositoryName, collaborationBranch, rootFolder)
        {
            Argument.AssertNotNull(accountName, nameof(accountName));
            Argument.AssertNotNull(repositoryName, nameof(repositoryName));
            Argument.AssertNotNull(collaborationBranch, nameof(collaborationBranch));
            Argument.AssertNotNull(rootFolder, nameof(rootFolder));

            FactoryRepoConfigurationType = "FactoryGitHubConfiguration";
        }

        /// <summary> Initializes a new instance of <see cref="FactoryGitHubConfiguration"/>. </summary>
        /// <param name="factoryRepoConfigurationType"> Type of repo configuration. </param>
        /// <param name="accountName"> Account name. </param>
        /// <param name="repositoryName"> Repository name. </param>
        /// <param name="collaborationBranch"> Collaboration branch. </param>
        /// <param name="rootFolder"> Root folder. </param>
        /// <param name="lastCommitId"> Last commit id. </param>
        /// <param name="disablePublish"> Disable manual publish operation in ADF studio to favor automated publish. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="hostName"> GitHub Enterprise host name. For example: `https://github.mydomain.com`. </param>
        /// <param name="clientId"> GitHub bring your own app client id. </param>
        /// <param name="clientSecret"> GitHub bring your own app client secret information. </param>
        internal FactoryGitHubConfiguration(string factoryRepoConfigurationType, string accountName, string repositoryName, string collaborationBranch, string rootFolder, string lastCommitId, bool? disablePublish, IDictionary<string, BinaryData> serializedAdditionalRawData, string hostName, string clientId, FactoryGitHubClientSecret clientSecret) : base(factoryRepoConfigurationType, accountName, repositoryName, collaborationBranch, rootFolder, lastCommitId, disablePublish, serializedAdditionalRawData)
        {
            HostName = hostName;
            ClientId = clientId;
            ClientSecret = clientSecret;
            FactoryRepoConfigurationType = factoryRepoConfigurationType ?? "FactoryGitHubConfiguration";
        }

        /// <summary> Initializes a new instance of <see cref="FactoryGitHubConfiguration"/> for deserialization. </summary>
        internal FactoryGitHubConfiguration()
        {
        }

        /// <summary> GitHub Enterprise host name. For example: `https://github.mydomain.com`. </summary>
        public string HostName { get; set; }
        /// <summary> GitHub bring your own app client id. </summary>
        public string ClientId { get; set; }
        /// <summary> GitHub bring your own app client secret information. </summary>
        public FactoryGitHubClientSecret ClientSecret { get; set; }
    }
}
