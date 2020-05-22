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
using Azure.Management.Resources.Models;

namespace Azure.Management.Resources
{
    /// <summary> The Applications service client. </summary>
    public partial class ApplicationsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal ApplicationsRestClient RestClient { get; }
        /// <summary> Initializes a new instance of ApplicationsClient for mocking. </summary>
        protected ApplicationsClient()
        {
        }
        /// <summary> Initializes a new instance of ApplicationsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal ApplicationsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new ApplicationsRestClient(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the managed application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Application>> GetAsync(string resourceGroupName, string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, applicationName, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the managed application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Application> Get(string resourceGroupName, string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, applicationName, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing managed application. The only value that can be updated via PATCH currently is the tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to update an existing managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Application>> UpdateAsync(string resourceGroupName, string applicationName, Application parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.Update");
            scope.Start();
            try
            {
                return await RestClient.UpdateAsync(resourceGroupName, applicationName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing managed application. The only value that can be updated via PATCH currently is the tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to update an existing managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Application> Update(string resourceGroupName, string applicationName, Application parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.Update");
            scope.Start();
            try
            {
                return RestClient.Update(resourceGroupName, applicationName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the managed application. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Application>> GetByIdAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.GetById");
            scope.Start();
            try
            {
                return await RestClient.GetByIdAsync(applicationId, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the managed application. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Application> GetById(string applicationId, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.GetById");
            scope.Start();
            try
            {
                return RestClient.GetById(applicationId, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing managed application. The only value that can be updated via PATCH currently is the tags. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="parameters"> Parameters supplied to update an existing managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Application>> UpdateByIdAsync(string applicationId, Application parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.UpdateById");
            scope.Start();
            try
            {
                return await RestClient.UpdateByIdAsync(applicationId, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates an existing managed application. The only value that can be updated via PATCH currently is the tags. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="parameters"> Parameters supplied to update an existing managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Application> UpdateById(string applicationId, Application parameters = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.UpdateById");
            scope.Start();
            try
            {
                return RestClient.UpdateById(applicationId, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the applications within a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Application> ListByResourceGroupAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = await RestClient.ListByResourceGroupNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all the applications within a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Application> ListByResourceGroup(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<Application> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroup(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListByResourceGroup");
                scope.Start();
                try
                {
                    var response = RestClient.ListByResourceGroupNextPage(nextLink, resourceGroupName, cancellationToken);
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

        /// <summary> Gets all the applications within a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<Application> ListBySubscriptionAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListBySubscription");
                scope.Start();
                try
                {
                    var response = await RestClient.ListBySubscriptionNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
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

        /// <summary> Gets all the applications within a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<Application> ListBySubscription(CancellationToken cancellationToken = default)
        {
            Page<Application> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscription(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.ListBySubscription");
                scope.Start();
                try
                {
                    var response = RestClient.ListBySubscriptionNextPage(nextLink, cancellationToken);
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

        /// <summary> Deletes the managed application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<ApplicationsDeleteOperation> StartDeleteAsync(string resourceGroupName, string applicationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, applicationName, cancellationToken).ConfigureAwait(false);
                return new ApplicationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, applicationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managed application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationsDeleteOperation StartDelete(string resourceGroupName, string applicationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, applicationName, cancellationToken);
                return new ApplicationsDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, applicationName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<ApplicationsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string applicationName, Application parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, applicationName, parameters, cancellationToken).ConfigureAwait(false);
                return new ApplicationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationsCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string applicationName, Application parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, applicationName, parameters, cancellationToken);
                return new ApplicationsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, applicationName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managed application. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<ApplicationsDeleteByIdOperation> StartDeleteByIdAsync(string applicationId, CancellationToken cancellationToken = default)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartDeleteById");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteByIdAsync(applicationId, cancellationToken).ConfigureAwait(false);
                return new ApplicationsDeleteByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteByIdRequest(applicationId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the managed application. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationsDeleteByIdOperation StartDeleteById(string applicationId, CancellationToken cancellationToken = default)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartDeleteById");
            scope.Start();
            try
            {
                var originalResponse = RestClient.DeleteById(applicationId, cancellationToken);
                return new ApplicationsDeleteByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteByIdRequest(applicationId).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async ValueTask<ApplicationsCreateOrUpdateByIdOperation> StartCreateOrUpdateByIdAsync(string applicationId, Application parameters, CancellationToken cancellationToken = default)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartCreateOrUpdateById");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateByIdAsync(applicationId, parameters, cancellationToken).ConfigureAwait(false);
                return new ApplicationsCreateOrUpdateByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateByIdRequest(applicationId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="applicationId"> The fully qualified ID of the managed application, including the managed application name and the managed application resource type. Use the format, /subscriptions/{guid}/resourceGroups/{resource-group-name}/Microsoft.Solutions/applications/{application-name}. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ApplicationsCreateOrUpdateByIdOperation StartCreateOrUpdateById(string applicationId, Application parameters, CancellationToken cancellationToken = default)
        {
            if (applicationId == null)
            {
                throw new ArgumentNullException(nameof(applicationId));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationsClient.StartCreateOrUpdateById");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdateById(applicationId, parameters, cancellationToken);
                return new ApplicationsCreateOrUpdateByIdOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateByIdRequest(applicationId, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
