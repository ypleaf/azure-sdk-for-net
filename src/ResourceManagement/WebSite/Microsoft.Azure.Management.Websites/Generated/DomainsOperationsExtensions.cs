// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for DomainsOperations.
    /// </summary>
    public static partial class DomainsOperationsExtensions
    {
            /// <summary>
            /// Checks if a domain is available for registration
            /// </summary>
            /// Checks if a domain is available for registration
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='identifier'>
            /// Name of the domain
            /// </param>
            public static DomainAvailablilityCheckResult CheckAvailability(this IDomainsOperations operations, NameIdentifier identifier)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).CheckAvailabilityAsync(identifier), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks if a domain is available for registration
            /// </summary>
            /// Checks if a domain is available for registration
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='identifier'>
            /// Name of the domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainAvailablilityCheckResult> CheckAvailabilityAsync(this IDomainsOperations operations, NameIdentifier identifier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CheckAvailabilityWithHttpMessagesAsync(identifier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all domains in a subscription
            /// </summary>
            /// Lists all domains in a subscription
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Domain> List(this IDomainsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).ListAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all domains in a subscription
            /// </summary>
            /// Lists all domains in a subscription
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListAsync(this IDomainsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Generates a single sign on request for domain management portal
            /// </summary>
            /// Generates a single sign on request for domain management portal
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static DomainControlCenterSsoRequest GetControlCenterSsoRequest(this IDomainsOperations operations)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).GetControlCenterSsoRequestAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a single sign on request for domain management portal
            /// </summary>
            /// Generates a single sign on request for domain management portal
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DomainControlCenterSsoRequest> GetControlCenterSsoRequestAsync(this IDomainsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetControlCenterSsoRequestWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists domain recommendations based on keywords
            /// </summary>
            /// Lists domain recommendations based on keywords
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Domain recommendation search parameters
            /// </param>
            public static IPage<NameIdentifier> ListRecommendations(this IDomainsOperations operations, DomainRecommendationSearchParameters parameters)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).ListRecommendationsAsync(parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists domain recommendations based on keywords
            /// </summary>
            /// Lists domain recommendations based on keywords
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='parameters'>
            /// Domain recommendation search parameters
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NameIdentifier>> ListRecommendationsAsync(this IDomainsOperations operations, DomainRecommendationSearchParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendationsWithHttpMessagesAsync(parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Validates domain registration information
            /// </summary>
            /// Validates domain registration information
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domainRegistrationInput'>
            /// Domain registration information
            /// </param>
            public static object ValidatePurchaseInformation(this IDomainsOperations operations, DomainRegistrationInput domainRegistrationInput)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).ValidatePurchaseInformationAsync(domainRegistrationInput), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Validates domain registration information
            /// </summary>
            /// Validates domain registration information
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='domainRegistrationInput'>
            /// Domain registration information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> ValidatePurchaseInformationAsync(this IDomainsOperations operations, DomainRegistrationInput domainRegistrationInput, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ValidatePurchaseInformationWithHttpMessagesAsync(domainRegistrationInput, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists domains under a resource group
            /// </summary>
            /// Lists domains under a resource group
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            public static IPage<Domain> ListByResourceGroup(this IDomainsOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists domains under a resource group
            /// </summary>
            /// Lists domains under a resource group
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListByResourceGroupAsync(this IDomainsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets details of a domain
            /// </summary>
            /// Gets details of a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            public static Domain Get(this IDomainsOperations operations, string resourceGroupName, string domainName)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).GetAsync(resourceGroupName, domainName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets details of a domain
            /// </summary>
            /// Gets details of a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> GetAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, domainName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a domain
            /// </summary>
            /// Creates a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// &amp;gt;Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domain'>
            /// Domain registration information
            /// </param>
            public static Domain CreateOrUpdate(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).CreateOrUpdateAsync(resourceGroupName, domainName, domain), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a domain
            /// </summary>
            /// Creates a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// &amp;gt;Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domain'>
            /// Domain registration information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> CreateOrUpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domain, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a domain
            /// </summary>
            /// Creates a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// &amp;gt;Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domain'>
            /// Domain registration information
            /// </param>
            public static Domain BeginCreateOrUpdate(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).BeginCreateOrUpdateAsync(resourceGroupName, domainName, domain), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a domain
            /// </summary>
            /// Creates a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// &amp;gt;Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='domain'>
            /// Domain registration information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> BeginCreateOrUpdateAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, Domain domain, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, domainName, domain, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a domain
            /// </summary>
            /// Deletes a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='forceHardDeleteDomain'>
            /// If true then the domain will be deleted immediately instead of after 24
            /// hours
            /// </param>
            public static object Delete(this IDomainsOperations operations, string resourceGroupName, string domainName, bool? forceHardDeleteDomain = default(bool?))
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).DeleteAsync(resourceGroupName, domainName, forceHardDeleteDomain), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a domain
            /// </summary>
            /// Deletes a domain
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='forceHardDeleteDomain'>
            /// If true then the domain will be deleted immediately instead of after 24
            /// hours
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> DeleteAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, bool? forceHardDeleteDomain = default(bool?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, domainName, forceHardDeleteDomain, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves the latest status of a domain purchase operation
            /// </summary>
            /// Retrieves the latest status of a domain purchase operation
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='operationId'>
            /// Domain purchase operation Id
            /// </param>
            public static Domain GetOperation(this IDomainsOperations operations, string resourceGroupName, string domainName, string operationId)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).GetOperationAsync(resourceGroupName, domainName, operationId), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves the latest status of a domain purchase operation
            /// </summary>
            /// Retrieves the latest status of a domain purchase operation
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group
            /// </param>
            /// <param name='domainName'>
            /// Name of the domain
            /// </param>
            /// <param name='operationId'>
            /// Domain purchase operation Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Domain> GetOperationAsync(this IDomainsOperations operations, string resourceGroupName, string domainName, string operationId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetOperationWithHttpMessagesAsync(resourceGroupName, domainName, operationId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all domains in a subscription
            /// </summary>
            /// Lists all domains in a subscription
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Domain> ListNext(this IDomainsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all domains in a subscription
            /// </summary>
            /// Lists all domains in a subscription
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListNextAsync(this IDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists domain recommendations based on keywords
            /// </summary>
            /// Lists domain recommendations based on keywords
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NameIdentifier> ListRecommendationsNext(this IDomainsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).ListRecommendationsNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists domain recommendations based on keywords
            /// </summary>
            /// Lists domain recommendations based on keywords
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NameIdentifier>> ListRecommendationsNextAsync(this IDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListRecommendationsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists domains under a resource group
            /// </summary>
            /// Lists domains under a resource group
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Domain> ListByResourceGroupNext(this IDomainsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IDomainsOperations)s).ListByResourceGroupNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists domains under a resource group
            /// </summary>
            /// Lists domains under a resource group
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Domain>> ListByResourceGroupNextAsync(this IDomainsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
