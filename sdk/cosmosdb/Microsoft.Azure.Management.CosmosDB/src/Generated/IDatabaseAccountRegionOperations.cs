// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// DatabaseAccountRegionOperations operations.
    /// </summary>
    public partial interface IDatabaseAccountRegionOperations
    {
        /// <summary>
        /// Retrieves the metrics determined by the given filter for the given
        /// database account and region.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group. The name is case insensitive.
        /// </param>
        /// <param name='accountName'>
        /// Cosmos DB database account name.
        /// </param>
        /// <param name='region'>
        /// Cosmos DB region, with spaces between words and each word
        /// capitalized.
        /// </param>
        /// <param name='filter'>
        /// An OData filter expression that describes a subset of metrics to
        /// return. The parameters that can be filtered are name.value (name of
        /// the metric, can have an or of multiple names), startTime, endTime,
        /// and timeGrain. The supported operator is eq.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IEnumerable<Metric>>> ListMetricsWithHttpMessagesAsync(string resourceGroupName, string accountName, string region, string filter, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
