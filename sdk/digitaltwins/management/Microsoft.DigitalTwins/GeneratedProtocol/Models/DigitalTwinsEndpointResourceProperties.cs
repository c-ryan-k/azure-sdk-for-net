// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.DigitalTwins.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties related to Digital Twins Endpoint
    /// </summary>
    [Newtonsoft.Json.JsonObject("DigitalTwinsEndpointResourceProperties")]
    public partial class DigitalTwinsEndpointResourceProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DigitalTwinsEndpointResourceProperties class.
        /// </summary>
        public DigitalTwinsEndpointResourceProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// DigitalTwinsEndpointResourceProperties class.
        /// </summary>
        /// <param name="provisioningState">The provisioning state. Possible
        /// values include: 'Provisioning', 'Deleting', 'Succeeded', 'Failed',
        /// 'Canceled'</param>
        /// <param name="createdTime">Time when the Endpoint was added to
        /// DigitalTwinsInstance.</param>
        /// <param name="tags">The resource tags.</param>
        public DigitalTwinsEndpointResourceProperties(string provisioningState = default(string), System.DateTime? createdTime = default(System.DateTime?), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            ProvisioningState = provisioningState;
            CreatedTime = createdTime;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the provisioning state. Possible values include:
        /// 'Provisioning', 'Deleting', 'Succeeded', 'Failed', 'Canceled'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; private set; }

        /// <summary>
        /// Gets time when the Endpoint was added to DigitalTwinsInstance.
        /// </summary>
        [JsonProperty(PropertyName = "createdTime")]
        public System.DateTime? CreatedTime { get; private set; }

        /// <summary>
        /// Gets or sets the resource tags.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
