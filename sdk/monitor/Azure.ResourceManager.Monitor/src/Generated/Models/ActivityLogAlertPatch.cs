// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> An Activity Log Alert rule object for the body of patch operations. </summary>
    public partial class ActivityLogAlertPatch
    {
        /// <summary> Initializes a new instance of <see cref="ActivityLogAlertPatch"/>. </summary>
        public ActivityLogAlertPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ActivityLogAlertPatch"/>. </summary>
        /// <param name="tags"> The resource tags. </param>
        /// <param name="isEnabled"> Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then none of its actions will be activated. </param>
        internal ActivityLogAlertPatch(IDictionary<string, string> tags, bool? isEnabled)
        {
            Tags = tags;
            IsEnabled = isEnabled;
        }

        /// <summary> The resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Indicates whether this Activity Log Alert rule is enabled. If an Activity Log Alert rule is not enabled, then none of its actions will be activated. </summary>
        public bool? IsEnabled { get; set; }
    }
}
