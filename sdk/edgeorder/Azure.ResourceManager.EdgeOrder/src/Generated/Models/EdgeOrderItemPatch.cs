// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Updates order item parameters. </summary>
    public partial class EdgeOrderItemPatch
    {
        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemPatch"/>. </summary>
        public EdgeOrderItemPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            NotificationEmailList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderItemPatch"/>. </summary>
        /// <param name="tags"> The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). </param>
        /// <param name="forwardAddress"> Updates forward shipping address and contact details. </param>
        /// <param name="preferences"> Customer preference. </param>
        /// <param name="notificationEmailList"> Additional notification email list. </param>
        internal EdgeOrderItemPatch(IDictionary<string, string> tags, EdgeOrderItemAddressProperties forwardAddress, OrderItemPreferences preferences, IList<string> notificationEmailList)
        {
            Tags = tags;
            ForwardAddress = forwardAddress;
            Preferences = preferences;
            NotificationEmailList = notificationEmailList;
        }

        /// <summary> The list of key value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Updates forward shipping address and contact details. </summary>
        public EdgeOrderItemAddressProperties ForwardAddress { get; set; }
        /// <summary> Customer preference. </summary>
        public OrderItemPreferences Preferences { get; set; }
        /// <summary> Additional notification email list. </summary>
        public IList<string> NotificationEmailList { get; }
    }
}
