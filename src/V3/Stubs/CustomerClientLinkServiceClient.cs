// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>
    /// Settings for a <see cref="CustomerClientLinkServiceClient"/>.
    /// </summary>
    public sealed partial class CustomerClientLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CustomerClientLinkServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CustomerClientLinkServiceSettings"/>.
        /// </returns>
        public static CustomerClientLinkServiceSettings GetDefault() => new CustomerClientLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerClientLinkServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerClientLinkServiceSettings() { }

        private CustomerClientLinkServiceSettings(CustomerClientLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerClientLinkSettings = existing.GetCustomerClientLinkSettings;
            MutateCustomerClientLinkSettings = existing.MutateCustomerClientLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerClientLinkServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CustomerClientLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="CustomerClientLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CustomerClientLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CustomerClientLinkServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CustomerClientLinkServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5000 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="CustomerClientLinkServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CustomerClientLinkServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CustomerClientLinkServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(3600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerClientLinkServiceClient.GetCustomerClientLink</c> and <c>CustomerClientLinkServiceClient.GetCustomerClientLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerClientLinkServiceClient.GetCustomerClientLink</c> and
        /// <c>CustomerClientLinkServiceClient.GetCustomerClientLinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerClientLinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerClientLinkServiceClient.MutateCustomerClientLink</c> and <c>CustomerClientLinkServiceClient.MutateCustomerClientLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CustomerClientLinkServiceClient.MutateCustomerClientLink</c> and
        /// <c>CustomerClientLinkServiceClient.MutateCustomerClientLinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomerClientLinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CustomerClientLinkServiceSettings"/> object.</returns>
        public CustomerClientLinkServiceSettings Clone() => new CustomerClientLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerClientLinkServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CustomerClientLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerClientLinkServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public CustomerClientLinkServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override CustomerClientLinkServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerClientLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<CustomerClientLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerClientLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => CustomerClientLinkServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerClientLinkServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerClientLinkServiceClient.ChannelPool;
    }

    /// <summary>
    /// CustomerClientLinkService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CustomerClientLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerClientLinkService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CustomerClientLinkService scopes.
        /// </summary>
        /// <remarks>
        /// The default CustomerClientLinkService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerClientLinkServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CustomerClientLinkServiceClient client = await CustomerClientLinkServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CustomerClientLinkServiceClient.DefaultEndpoint.Host, CustomerClientLinkServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerClientLinkServiceClient client = CustomerClientLinkServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerClientLinkServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CustomerClientLinkServiceClient"/>.</returns>
        public static async stt::Task<CustomerClientLinkServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CustomerClientLinkServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CustomerClientLinkServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CustomerClientLinkServiceClient client = CustomerClientLinkServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CustomerClientLinkServiceClient.DefaultEndpoint.Host, CustomerClientLinkServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CustomerClientLinkServiceClient client = CustomerClientLinkServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CustomerClientLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerClientLinkServiceClient"/>.</returns>
        public static CustomerClientLinkServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CustomerClientLinkServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerClientLinkServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerClientLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerClientLinkServiceClient"/>.</returns>
        public static CustomerClientLinkServiceClient Create(grpccore::Channel channel, CustomerClientLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CustomerClientLinkServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CustomerClientLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerClientLinkServiceClient"/>.</returns>
        public static CustomerClientLinkServiceClient Create(grpccore::CallInvoker callInvoker, CustomerClientLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerClientLinkService.CustomerClientLinkServiceClient grpcClient = new CustomerClientLinkService.CustomerClientLinkServiceClient(callInvoker);
            return new CustomerClientLinkServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerClientLinkServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerClientLinkServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CustomerClientLinkServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CustomerClientLinkServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CustomerClientLinkService client.
        /// </summary>
        public virtual CustomerClientLinkService.CustomerClientLinkServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomerClientLinkAsync(
                new GetCustomerClientLinkRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCustomerClientLinkAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer client link to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CustomerClientLink GetCustomerClientLink(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCustomerClientLink(
                new GetCustomerClientLinkRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(
            GetCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(
            GetCustomerClientLinkRequest request,
            st::CancellationToken cancellationToken) => GetCustomerClientLinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CustomerClientLink GetCustomerClientLink(
            GetCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer link are being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the individual CustomerClientLink.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(
            string customerId,
            CustomerClientLinkOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerClientLinkAsync(
                new MutateCustomerClientLinkRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer link are being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the individual CustomerClientLink.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(
            string customerId,
            CustomerClientLinkOperation operation,
            st::CancellationToken cancellationToken) => MutateCustomerClientLinkAsync(
                customerId,
                operation,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer link are being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the individual CustomerClientLink.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerClientLinkResponse MutateCustomerClientLink(
            string customerId,
            CustomerClientLinkOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateCustomerClientLink(
                new MutateCustomerClientLinkRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(
            MutateCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(
            MutateCustomerClientLinkRequest request,
            st::CancellationToken cancellationToken) => MutateCustomerClientLinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCustomerClientLinkResponse MutateCustomerClientLink(
            MutateCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CustomerClientLinkService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CustomerClientLinkServiceClientImpl : CustomerClientLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerClientLinkRequest, gagvr::CustomerClientLink> _callGetCustomerClientLink;
        private readonly gaxgrpc::ApiCall<MutateCustomerClientLinkRequest, MutateCustomerClientLinkResponse> _callMutateCustomerClientLink;

        /// <summary>
        /// Constructs a client wrapper for the CustomerClientLinkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerClientLinkServiceSettings"/> used within this client </param>
        public CustomerClientLinkServiceClientImpl(CustomerClientLinkService.CustomerClientLinkServiceClient grpcClient, CustomerClientLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerClientLinkServiceSettings effectiveSettings = settings ?? CustomerClientLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerClientLink = clientHelper.BuildApiCall<GetCustomerClientLinkRequest, gagvr::CustomerClientLink>(
                GrpcClient.GetCustomerClientLinkAsync, GrpcClient.GetCustomerClientLink, effectiveSettings.GetCustomerClientLinkSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callMutateCustomerClientLink = clientHelper.BuildApiCall<MutateCustomerClientLinkRequest, MutateCustomerClientLinkResponse>(
                GrpcClient.MutateCustomerClientLinkAsync, GrpcClient.MutateCustomerClientLink, effectiveSettings.MutateCustomerClientLinkSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callGetCustomerClientLink);
            Modify_GetCustomerClientLinkApiCall(ref _callGetCustomerClientLink);
            Modify_ApiCall(ref _callMutateCustomerClientLink);
            Modify_MutateCustomerClientLinkApiCall(ref _callMutateCustomerClientLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetCustomerClientLinkApiCall(ref gaxgrpc::ApiCall<GetCustomerClientLinkRequest, gagvr::CustomerClientLink> call);
        partial void Modify_MutateCustomerClientLinkApiCall(ref gaxgrpc::ApiCall<MutateCustomerClientLinkRequest, MutateCustomerClientLinkResponse> call);
        partial void OnConstruction(CustomerClientLinkService.CustomerClientLinkServiceClient grpcClient, CustomerClientLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CustomerClientLinkService client.
        /// </summary>
        public override CustomerClientLinkService.CustomerClientLinkServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCustomerClientLinkRequest(ref GetCustomerClientLinkRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCustomerClientLinkRequest(ref MutateCustomerClientLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gagvr::CustomerClientLink> GetCustomerClientLinkAsync(
            GetCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerClientLinkRequest(ref request, ref callSettings);
            return _callGetCustomerClientLink.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested CustomerClientLink in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gagvr::CustomerClientLink GetCustomerClientLink(
            GetCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerClientLinkRequest(ref request, ref callSettings);
            return _callGetCustomerClientLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<MutateCustomerClientLinkResponse> MutateCustomerClientLinkAsync(
            MutateCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerClientLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerClientLink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a customer client link. Operation statuses are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override MutateCustomerClientLinkResponse MutateCustomerClientLink(
            MutateCustomerClientLinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerClientLinkRequest(ref request, ref callSettings);
            return _callMutateCustomerClientLink.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}
