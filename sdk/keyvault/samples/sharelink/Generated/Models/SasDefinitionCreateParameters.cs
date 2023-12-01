// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The SAS definition create parameters. </summary>
    internal partial class SasDefinitionCreateParameters
    {
        /// <summary> Initializes a new instance of <see cref="SasDefinitionCreateParameters"/>. </summary>
        /// <param name="templateUri"> The SAS definition token template signed with an arbitrary key.  Tokens created according to the SAS definition will have the same properties as the template. </param>
        /// <param name="sasType"> The type of SAS token the SAS definition will create. </param>
        /// <param name="validityPeriod"> The validity period of SAS tokens created according to the SAS definition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="templateUri"/> or <paramref name="validityPeriod"/> is null. </exception>
        public SasDefinitionCreateParameters(string templateUri, SasTokenType sasType, string validityPeriod)
        {
            Argument.AssertNotNull(templateUri, nameof(templateUri));
            Argument.AssertNotNull(validityPeriod, nameof(validityPeriod));

            TemplateUri = templateUri;
            SasType = sasType;
            ValidityPeriod = validityPeriod;
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="SasDefinitionCreateParameters"/>. </summary>
        /// <param name="templateUri"> The SAS definition token template signed with an arbitrary key.  Tokens created according to the SAS definition will have the same properties as the template. </param>
        /// <param name="sasType"> The type of SAS token the SAS definition will create. </param>
        /// <param name="validityPeriod"> The validity period of SAS tokens created according to the SAS definition. </param>
        /// <param name="sasDefinitionAttributes"> The attributes of the SAS definition. </param>
        /// <param name="tags"> Application specific metadata in the form of key-value pairs. </param>
        internal SasDefinitionCreateParameters(string templateUri, SasTokenType sasType, string validityPeriod, SasDefinitionAttributes sasDefinitionAttributes, IDictionary<string, string> tags)
        {
            TemplateUri = templateUri;
            SasType = sasType;
            ValidityPeriod = validityPeriod;
            SasDefinitionAttributes = sasDefinitionAttributes;
            Tags = tags;
        }

        /// <summary> The SAS definition token template signed with an arbitrary key.  Tokens created according to the SAS definition will have the same properties as the template. </summary>
        public string TemplateUri { get; }
        /// <summary> The type of SAS token the SAS definition will create. </summary>
        public SasTokenType SasType { get; }
        /// <summary> The validity period of SAS tokens created according to the SAS definition. </summary>
        public string ValidityPeriod { get; }
        /// <summary> The attributes of the SAS definition. </summary>
        public SasDefinitionAttributes SasDefinitionAttributes { get; set; }
        /// <summary> Application specific metadata in the form of key-value pairs. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
