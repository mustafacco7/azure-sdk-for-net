// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Net;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Discover protectable item properties. </summary>
    public partial class DiscoverProtectableItemProperties
    {
        /// <summary> Initializes a new instance of <see cref="DiscoverProtectableItemProperties"/>. </summary>
        public DiscoverProtectableItemProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiscoverProtectableItemProperties"/>. </summary>
        /// <param name="friendlyName"> The friendly name of the physical machine. </param>
        /// <param name="ipAddress"> The IP address of the physical machine to be discovered. </param>
        /// <param name="osType"> The OS type on the physical machine. </param>
        internal DiscoverProtectableItemProperties(string friendlyName, IPAddress ipAddress, string osType)
        {
            FriendlyName = friendlyName;
            IPAddress = ipAddress;
            OSType = osType;
        }

        /// <summary> The friendly name of the physical machine. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The IP address of the physical machine to be discovered. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> The OS type on the physical machine. </summary>
        public string OSType { get; set; }
    }
}
