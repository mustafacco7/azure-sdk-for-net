// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Work item configuration creation payload. </summary>
    public partial class WorkItemCreateConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="WorkItemCreateConfiguration"/>. </summary>
        public WorkItemCreateConfiguration()
        {
            WorkItemProperties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="WorkItemCreateConfiguration"/>. </summary>
        /// <param name="connectorId"> Unique connector id. </param>
        /// <param name="connectorDataConfiguration"> Serialized JSON object for detailed properties. </param>
        /// <param name="isValidateOnly"> Boolean indicating validate only. </param>
        /// <param name="workItemProperties"> Custom work item properties. </param>
        internal WorkItemCreateConfiguration(string connectorId, string connectorDataConfiguration, bool? isValidateOnly, IDictionary<string, string> workItemProperties)
        {
            ConnectorId = connectorId;
            ConnectorDataConfiguration = connectorDataConfiguration;
            IsValidateOnly = isValidateOnly;
            WorkItemProperties = workItemProperties;
        }

        /// <summary> Unique connector id. </summary>
        public string ConnectorId { get; set; }
        /// <summary> Serialized JSON object for detailed properties. </summary>
        public string ConnectorDataConfiguration { get; set; }
        /// <summary> Boolean indicating validate only. </summary>
        public bool? IsValidateOnly { get; set; }
        /// <summary> Custom work item properties. </summary>
        public IDictionary<string, string> WorkItemProperties { get; }
    }
}
