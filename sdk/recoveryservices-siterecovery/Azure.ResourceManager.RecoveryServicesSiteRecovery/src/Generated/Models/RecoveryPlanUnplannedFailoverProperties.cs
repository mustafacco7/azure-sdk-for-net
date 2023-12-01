// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan unplanned failover input properties. </summary>
    public partial class RecoveryPlanUnplannedFailoverProperties
    {
        /// <summary> Initializes a new instance of <see cref="RecoveryPlanUnplannedFailoverProperties"/>. </summary>
        /// <param name="failoverDirection"> The failover direction. </param>
        /// <param name="sourceSiteOperation"> A value indicating whether source site operations are required. </param>
        public RecoveryPlanUnplannedFailoverProperties(PossibleOperationsDirection failoverDirection, SourceSiteOperation sourceSiteOperation)
        {
            FailoverDirection = failoverDirection;
            SourceSiteOperation = sourceSiteOperation;
            ProviderSpecificDetails = new ChangeTrackingList<RecoveryPlanProviderSpecificFailoverContent>();
        }

        /// <summary> Initializes a new instance of <see cref="RecoveryPlanUnplannedFailoverProperties"/>. </summary>
        /// <param name="failoverDirection"> The failover direction. </param>
        /// <param name="sourceSiteOperation"> A value indicating whether source site operations are required. </param>
        /// <param name="providerSpecificDetails">
        /// The provider specific properties.
        /// Please note <see cref="RecoveryPlanProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailbackContent"/>, <see cref="RecoveryPlanInMageFailoverContent"/>, <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>, <see cref="RecoveryPlanInMageRcmFailoverContent"/> and <see cref="RecoveryPlanInMageRcmFailbackFailoverContent"/>.
        /// </param>
        internal RecoveryPlanUnplannedFailoverProperties(PossibleOperationsDirection failoverDirection, SourceSiteOperation sourceSiteOperation, IList<RecoveryPlanProviderSpecificFailoverContent> providerSpecificDetails)
        {
            FailoverDirection = failoverDirection;
            SourceSiteOperation = sourceSiteOperation;
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary> The failover direction. </summary>
        public PossibleOperationsDirection FailoverDirection { get; }
        /// <summary> A value indicating whether source site operations are required. </summary>
        public SourceSiteOperation SourceSiteOperation { get; }
        /// <summary>
        /// The provider specific properties.
        /// Please note <see cref="RecoveryPlanProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailoverContent"/>, <see cref="RecoveryPlanHyperVReplicaAzureFailbackContent"/>, <see cref="RecoveryPlanInMageFailoverContent"/>, <see cref="RecoveryPlanInMageAzureV2FailoverContent"/>, <see cref="RecoveryPlanInMageRcmFailoverContent"/> and <see cref="RecoveryPlanInMageRcmFailbackFailoverContent"/>.
        /// </summary>
        public IList<RecoveryPlanProviderSpecificFailoverContent> ProviderSpecificDetails { get; }
    }
}
