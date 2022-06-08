// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the AfdRule data model. </summary>
    public partial class AfdRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of AfdRuleData. </summary>
        public AfdRuleData()
        {
            Conditions = new ChangeTrackingList<DeliveryRuleCondition>();
            Actions = new ChangeTrackingList<DeliveryRuleAction>();
        }

        /// <summary> Initializes a new instance of AfdRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="ruleSetName"> The name of the rule set containing the rule. </param>
        /// <param name="order"> The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied. </param>
        /// <param name="conditions">
        /// A list of conditions that must be matched for the actions to be executed
        /// Please note <see cref="DeliveryRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleClientPortCondition"/>, <see cref="DeliveryRuleCookiesCondition"/>, <see cref="DeliveryRuleHostNameCondition"/>, <see cref="DeliveryRuleHttpVersionCondition"/>, <see cref="DeliveryRuleIsDeviceCondition"/>, <see cref="DeliveryRulePostArgsCondition"/>, <see cref="DeliveryRuleQueryStringCondition"/>, <see cref="DeliveryRuleRemoteAddressCondition"/>, <see cref="DeliveryRuleRequestBodyCondition"/>, <see cref="DeliveryRuleRequestHeaderCondition"/>, <see cref="DeliveryRuleRequestMethodCondition"/>, <see cref="DeliveryRuleRequestSchemeCondition"/>, <see cref="DeliveryRuleRequestUriCondition"/>, <see cref="DeliveryRuleServerPortCondition"/>, <see cref="DeliveryRuleSocketAddressCondition"/>, <see cref="DeliveryRuleSslProtocolCondition"/>, <see cref="DeliveryRuleUriFileExtensionCondition"/>, <see cref="DeliveryRuleUriFileNameCondition"/> and <see cref="DeliveryRuleUriPathCondition"/>.
        /// </param>
        /// <param name="actions">
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleCacheExpirationAction"/>, <see cref="DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="DeliveryRuleRequestHeaderAction"/>, <see cref="DeliveryRuleResponseHeaderAction"/>, <see cref="OriginGroupOverrideAction"/>, <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="UriRedirectAction"/>, <see cref="UriRewriteAction"/> and <see cref="UriSigningAction"/>.
        /// </param>
        /// <param name="matchProcessingBehavior"> If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue. </param>
        /// <param name="provisioningState"> Provisioning status. </param>
        /// <param name="deploymentStatus"></param>
        internal AfdRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string ruleSetName, int? order, IList<DeliveryRuleCondition> conditions, IList<DeliveryRuleAction> actions, MatchProcessingBehavior? matchProcessingBehavior, AfdProvisioningState? provisioningState, AfdDeploymentStatus? deploymentStatus) : base(id, name, resourceType, systemData)
        {
            RuleSetName = ruleSetName;
            Order = order;
            Conditions = conditions;
            Actions = actions;
            MatchProcessingBehavior = matchProcessingBehavior;
            ProvisioningState = provisioningState;
            DeploymentStatus = deploymentStatus;
        }

        /// <summary> The name of the rule set containing the rule. </summary>
        public string RuleSetName { get; }
        /// <summary> The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied. </summary>
        public int? Order { get; set; }
        /// <summary>
        /// A list of conditions that must be matched for the actions to be executed
        /// Please note <see cref="DeliveryRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleClientPortCondition"/>, <see cref="DeliveryRuleCookiesCondition"/>, <see cref="DeliveryRuleHostNameCondition"/>, <see cref="DeliveryRuleHttpVersionCondition"/>, <see cref="DeliveryRuleIsDeviceCondition"/>, <see cref="DeliveryRulePostArgsCondition"/>, <see cref="DeliveryRuleQueryStringCondition"/>, <see cref="DeliveryRuleRemoteAddressCondition"/>, <see cref="DeliveryRuleRequestBodyCondition"/>, <see cref="DeliveryRuleRequestHeaderCondition"/>, <see cref="DeliveryRuleRequestMethodCondition"/>, <see cref="DeliveryRuleRequestSchemeCondition"/>, <see cref="DeliveryRuleRequestUriCondition"/>, <see cref="DeliveryRuleServerPortCondition"/>, <see cref="DeliveryRuleSocketAddressCondition"/>, <see cref="DeliveryRuleSslProtocolCondition"/>, <see cref="DeliveryRuleUriFileExtensionCondition"/>, <see cref="DeliveryRuleUriFileNameCondition"/> and <see cref="DeliveryRuleUriPathCondition"/>.
        /// </summary>
        public IList<DeliveryRuleCondition> Conditions { get; }
        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleCacheExpirationAction"/>, <see cref="DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="DeliveryRuleRequestHeaderAction"/>, <see cref="DeliveryRuleResponseHeaderAction"/>, <see cref="OriginGroupOverrideAction"/>, <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="UriRedirectAction"/>, <see cref="UriRewriteAction"/> and <see cref="UriSigningAction"/>.
        /// </summary>
        public IList<DeliveryRuleAction> Actions { get; }
        /// <summary> If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue. </summary>
        public MatchProcessingBehavior? MatchProcessingBehavior { get; set; }
        /// <summary> Provisioning status. </summary>
        public AfdProvisioningState? ProvisioningState { get; }
        /// <summary> Gets the deployment status. </summary>
        public AfdDeploymentStatus? DeploymentStatus { get; }
    }
}
