// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> Service End point policy resource. </summary>
    public partial class ServiceEndpointPolicy : Resource
    {
        /// <summary> Initializes a new instance of ServiceEndpointPolicy. </summary>
        public ServiceEndpointPolicy()
        {
        }

        /// <summary> Initializes a new instance of ServiceEndpointPolicy. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="serviceEndpointPolicyDefinitions"> A collection of service endpoint policy definitions of the service endpoint policy. </param>
        /// <param name="subnets"> A collection of references to subnets. </param>
        /// <param name="resourceGuid"> The resource GUID property of the service endpoint policy resource. </param>
        /// <param name="provisioningState"> The provisioning state of the service endpoint policy resource. </param>
        internal ServiceEndpointPolicy(string id, string name, string type, string location, IDictionary<string, string> tags, string etag, IList<ServiceEndpointPolicyDefinition> serviceEndpointPolicyDefinitions, IList<Subnet> subnets, string resourceGuid, ProvisioningState? provisioningState) : base(id, name, type, location, tags)
        {
            Etag = etag;
            ServiceEndpointPolicyDefinitions = serviceEndpointPolicyDefinitions;
            Subnets = subnets;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> A collection of service endpoint policy definitions of the service endpoint policy. </summary>
        public IList<ServiceEndpointPolicyDefinition> ServiceEndpointPolicyDefinitions { get; set; }
        /// <summary> A collection of references to subnets. </summary>
        public IList<Subnet> Subnets { get; }
        /// <summary> The resource GUID property of the service endpoint policy resource. </summary>
        public string ResourceGuid { get; }
        /// <summary> The provisioning state of the service endpoint policy resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
