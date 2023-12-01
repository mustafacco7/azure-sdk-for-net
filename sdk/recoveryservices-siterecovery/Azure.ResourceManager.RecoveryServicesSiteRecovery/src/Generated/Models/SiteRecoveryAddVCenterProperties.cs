// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Net;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The properties of an add vCenter request. </summary>
    public partial class SiteRecoveryAddVCenterProperties
    {
        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAddVCenterProperties"/>. </summary>
        public SiteRecoveryAddVCenterProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAddVCenterProperties"/>. </summary>
        /// <param name="friendlyName"> The friendly name of the vCenter. </param>
        /// <param name="ipAddress"> The IP address of the vCenter to be discovered. </param>
        /// <param name="processServerId"> The process server Id from where the discovery is orchestrated. </param>
        /// <param name="port"> The port number for discovery. </param>
        /// <param name="runAsAccountId"> The account Id which has privileges to discover the vCenter. </param>
        internal SiteRecoveryAddVCenterProperties(string friendlyName, IPAddress ipAddress, Guid? processServerId, string port, string runAsAccountId)
        {
            FriendlyName = friendlyName;
            IPAddress = ipAddress;
            ProcessServerId = processServerId;
            Port = port;
            RunAsAccountId = runAsAccountId;
        }

        /// <summary> The friendly name of the vCenter. </summary>
        public string FriendlyName { get; set; }
        /// <summary> The IP address of the vCenter to be discovered. </summary>
        public IPAddress IPAddress { get; set; }
        /// <summary> The process server Id from where the discovery is orchestrated. </summary>
        public Guid? ProcessServerId { get; set; }
        /// <summary> The port number for discovery. </summary>
        public string Port { get; set; }
        /// <summary> The account Id which has privileges to discover the vCenter. </summary>
        public string RunAsAccountId { get; set; }
    }
}
