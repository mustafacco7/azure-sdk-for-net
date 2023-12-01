// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Guest disk signature based disk exclusion option when doing enable protection of virtual machine in InMage provider. </summary>
    public partial class InMageVolumeExclusionOptions
    {
        /// <summary> Initializes a new instance of <see cref="InMageVolumeExclusionOptions"/>. </summary>
        public InMageVolumeExclusionOptions()
        {
        }

        /// <summary> Initializes a new instance of <see cref="InMageVolumeExclusionOptions"/>. </summary>
        /// <param name="volumeLabel"> The volume label. The disk having any volume with this label will be excluded from replication. </param>
        /// <param name="onlyExcludeIfSingleVolume"> The value indicating whether to exclude multi volume disk or not. If a disk has multiple volumes and one of the volume has label matching with VolumeLabel this disk will be excluded from replication if OnlyExcludeIfSingleVolume is false. </param>
        internal InMageVolumeExclusionOptions(string volumeLabel, string onlyExcludeIfSingleVolume)
        {
            VolumeLabel = volumeLabel;
            OnlyExcludeIfSingleVolume = onlyExcludeIfSingleVolume;
        }

        /// <summary> The volume label. The disk having any volume with this label will be excluded from replication. </summary>
        public string VolumeLabel { get; set; }
        /// <summary> The value indicating whether to exclude multi volume disk or not. If a disk has multiple volumes and one of the volume has label matching with VolumeLabel this disk will be excluded from replication if OnlyExcludeIfSingleVolume is false. </summary>
        public string OnlyExcludeIfSingleVolume { get; set; }
    }
}
