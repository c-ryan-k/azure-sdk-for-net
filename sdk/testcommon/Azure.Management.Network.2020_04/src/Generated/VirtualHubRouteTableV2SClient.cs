// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The VirtualHubRouteTableV2S service client. </summary>
    public partial class VirtualHubRouteTableV2SClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal VirtualHubRouteTableV2SRestClient RestClient { get; }
        /// <summary> Initializes a new instance of VirtualHubRouteTableV2SClient for mocking. </summary>
        protected VirtualHubRouteTableV2SClient()
        {
        }
        /// <summary> Initializes a new instance of VirtualHubRouteTableV2SClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal VirtualHubRouteTableV2SClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new VirtualHubRouteTableV2SRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieves the details of a VirtualHubRouteTableV2. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<VirtualHubRouteTableV2>> GetAsync(string resourceGroupName, string virtualHubName, string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, virtualHubName, routeTableName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of a VirtualHubRouteTableV2. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<VirtualHubRouteTableV2> Get(string resourceGroupName, string virtualHubName, string routeTableName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, virtualHubName, routeTableName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieves the details of all VirtualHubRouteTableV2s. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<VirtualHubRouteTableV2> ListAsync(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            async Task<Page<VirtualHubRouteTableV2>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, virtualHubName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<VirtualHubRouteTableV2>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, virtualHubName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Retrieves the details of all VirtualHubRouteTableV2s. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<VirtualHubRouteTableV2> List(string resourceGroupName, string virtualHubName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }

            Page<VirtualHubRouteTableV2> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, virtualHubName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<VirtualHubRouteTableV2> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, virtualHubName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualHubRouteTableV2SCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string virtualHubName, string routeTableName, VirtualHubRouteTableV2 virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, virtualHubName, routeTableName, virtualHubRouteTableV2Parameters, cancellationToken).ConfigureAwait(false);
                return new VirtualHubRouteTableV2SCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, virtualHubName, routeTableName, virtualHubRouteTableV2Parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a VirtualHubRouteTableV2 resource if it doesn&apos;t exist else updates the existing VirtualHubRouteTableV2. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHub. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubRouteTableV2Parameters"> Parameters supplied to create or update VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualHubRouteTableV2SCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string virtualHubName, string routeTableName, VirtualHubRouteTableV2 virtualHubRouteTableV2Parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }
            if (virtualHubRouteTableV2Parameters == null)
            {
                throw new ArgumentNullException(nameof(virtualHubRouteTableV2Parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, virtualHubName, routeTableName, virtualHubRouteTableV2Parameters, cancellationToken);
                return new VirtualHubRouteTableV2SCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, virtualHubName, routeTableName, virtualHubRouteTableV2Parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHubRouteTableV2. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<VirtualHubRouteTableV2SDeleteOperation> StartDeleteAsync(string resourceGroupName, string virtualHubName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, virtualHubName, routeTableName, cancellationToken).ConfigureAwait(false);
                return new VirtualHubRouteTableV2SDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, virtualHubName, routeTableName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes a VirtualHubRouteTableV2. </summary>
        /// <param name="resourceGroupName"> The resource group name of the VirtualHubRouteTableV2. </param>
        /// <param name="virtualHubName"> The name of the VirtualHub. </param>
        /// <param name="routeTableName"> The name of the VirtualHubRouteTableV2. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual VirtualHubRouteTableV2SDeleteOperation StartDelete(string resourceGroupName, string virtualHubName, string routeTableName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualHubName == null)
            {
                throw new ArgumentNullException(nameof(virtualHubName));
            }
            if (routeTableName == null)
            {
                throw new ArgumentNullException(nameof(routeTableName));
            }

            using var scope = _clientDiagnostics.CreateScope("VirtualHubRouteTableV2SClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, virtualHubName, routeTableName, cancellationToken);
                return new VirtualHubRouteTableV2SDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, virtualHubName, routeTableName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
