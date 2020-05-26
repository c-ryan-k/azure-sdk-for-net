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
    using System.Linq;

    /// <summary>
    /// Definition of a Resource.
    /// </summary>
    public partial class ExternalResource
    {
        /// <summary>
        /// Initializes a new instance of the ExternalResource class.
        /// </summary>
        public ExternalResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ExternalResource class.
        /// </summary>
        /// <param name="id">The resource identifier.</param>
        /// <param name="name">Extension resource name.</param>
        /// <param name="type">The resource type.</param>
        public ExternalResource(string id = default(string), string name = default(string), string type = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the resource identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets extension resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
