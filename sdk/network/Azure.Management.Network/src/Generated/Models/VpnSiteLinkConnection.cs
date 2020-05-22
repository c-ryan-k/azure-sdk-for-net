// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Network.Models
{
    /// <summary> VpnSiteLinkConnection Resource. </summary>
    public partial class VpnSiteLinkConnection : SubResource
    {
        /// <summary> Initializes a new instance of VpnSiteLinkConnection. </summary>
        public VpnSiteLinkConnection()
        {
        }

        /// <summary> Initializes a new instance of VpnSiteLinkConnection. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> The name of the resource that is unique within a resource group. This name can be used to access the resource. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="vpnSiteLink"> Id of the connected vpn site link. </param>
        /// <param name="routingWeight"> Routing weight for vpn connection. </param>
        /// <param name="connectionStatus"> The connection status. </param>
        /// <param name="vpnConnectionProtocolType"> Connection protocol used for this connection. </param>
        /// <param name="ingressBytesTransferred"> Ingress bytes transferred. </param>
        /// <param name="egressBytesTransferred"> Egress bytes transferred. </param>
        /// <param name="connectionBandwidth"> Expected bandwidth in MBPS. </param>
        /// <param name="sharedKey"> SharedKey for the vpn connection. </param>
        /// <param name="enableBgp"> EnableBgp flag. </param>
        /// <param name="usePolicyBasedTrafficSelectors"> Enable policy-based traffic selectors. </param>
        /// <param name="ipsecPolicies"> The IPSec Policies to be considered by this connection. </param>
        /// <param name="enableRateLimiting"> EnableBgp flag. </param>
        /// <param name="useLocalAzureIpAddress"> Use local azure ip to initiate connection. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN site link connection resource. </param>
        internal VpnSiteLinkConnection(string id, string name, string etag, string type, SubResource vpnSiteLink, int? routingWeight, VpnConnectionStatus? connectionStatus, VirtualNetworkGatewayConnectionProtocol? vpnConnectionProtocolType, long? ingressBytesTransferred, long? egressBytesTransferred, int? connectionBandwidth, string sharedKey, bool? enableBgp, bool? usePolicyBasedTrafficSelectors, IList<IpsecPolicy> ipsecPolicies, bool? enableRateLimiting, bool? useLocalAzureIpAddress, ProvisioningState? provisioningState) : base(id)
        {
            Name = name;
            Etag = etag;
            Type = type;
            VpnSiteLink = vpnSiteLink;
            RoutingWeight = routingWeight;
            ConnectionStatus = connectionStatus;
            VpnConnectionProtocolType = vpnConnectionProtocolType;
            IngressBytesTransferred = ingressBytesTransferred;
            EgressBytesTransferred = egressBytesTransferred;
            ConnectionBandwidth = connectionBandwidth;
            SharedKey = sharedKey;
            EnableBgp = enableBgp;
            UsePolicyBasedTrafficSelectors = usePolicyBasedTrafficSelectors;
            IpsecPolicies = ipsecPolicies;
            EnableRateLimiting = enableRateLimiting;
            UseLocalAzureIpAddress = useLocalAzureIpAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> The name of the resource that is unique within a resource group. This name can be used to access the resource. </summary>
        public string Name { get; set; }
        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Resource type. </summary>
        public string Type { get; }
        /// <summary> Id of the connected vpn site link. </summary>
        public SubResource VpnSiteLink { get; set; }
        /// <summary> Routing weight for vpn connection. </summary>
        public int? RoutingWeight { get; set; }
        /// <summary> The connection status. </summary>
        public VpnConnectionStatus? ConnectionStatus { get; }
        /// <summary> Connection protocol used for this connection. </summary>
        public VirtualNetworkGatewayConnectionProtocol? VpnConnectionProtocolType { get; set; }
        /// <summary> Ingress bytes transferred. </summary>
        public long? IngressBytesTransferred { get; }
        /// <summary> Egress bytes transferred. </summary>
        public long? EgressBytesTransferred { get; }
        /// <summary> Expected bandwidth in MBPS. </summary>
        public int? ConnectionBandwidth { get; set; }
        /// <summary> SharedKey for the vpn connection. </summary>
        public string SharedKey { get; set; }
        /// <summary> EnableBgp flag. </summary>
        public bool? EnableBgp { get; set; }
        /// <summary> Enable policy-based traffic selectors. </summary>
        public bool? UsePolicyBasedTrafficSelectors { get; set; }
        /// <summary> The IPSec Policies to be considered by this connection. </summary>
        public IList<IpsecPolicy> IpsecPolicies { get; set; }
        /// <summary> EnableBgp flag. </summary>
        public bool? EnableRateLimiting { get; set; }
        /// <summary> Use local azure ip to initiate connection. </summary>
        public bool? UseLocalAzureIpAddress { get; set; }
        /// <summary> The provisioning state of the VPN site link connection resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
