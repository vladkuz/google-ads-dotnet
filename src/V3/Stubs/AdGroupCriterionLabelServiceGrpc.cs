// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/ad_group_criterion_label_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V3.Services {
  /// <summary>
  /// Service to manage labels on ad group criteria.
  /// </summary>
  public static partial class AdGroupCriterionLabelService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.AdGroupCriterionLabelService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest> __Marshaller_google_ads_googleads_v3_services_GetAdGroupCriterionLabelRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel> __Marshaller_google_ads_googleads_v3_resources_AdGroupCriterionLabel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest> __Marshaller_google_ads_googleads_v3_services_MutateAdGroupCriterionLabelsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse> __Marshaller_google_ads_googleads_v3_services_MutateAdGroupCriterionLabelsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest, global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel> __Method_GetAdGroupCriterionLabel = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest, global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAdGroupCriterionLabel",
        __Marshaller_google_ads_googleads_v3_services_GetAdGroupCriterionLabelRequest,
        __Marshaller_google_ads_googleads_v3_resources_AdGroupCriterionLabel);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse> __Method_MutateAdGroupCriterionLabels = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateAdGroupCriterionLabels",
        __Marshaller_google_ads_googleads_v3_services_MutateAdGroupCriterionLabelsRequest,
        __Marshaller_google_ads_googleads_v3_services_MutateAdGroupCriterionLabelsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupCriterionLabelServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AdGroupCriterionLabelService</summary>
    public abstract partial class AdGroupCriterionLabelServiceBase
    {
      /// <summary>
      /// Returns the requested ad group criterion label in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel> GetAdGroupCriterionLabel(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates and removes ad group criterion labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabels(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AdGroupCriterionLabelService</summary>
    public partial class AdGroupCriterionLabelServiceClient : grpc::ClientBase<AdGroupCriterionLabelServiceClient>
    {
      /// <summary>Creates a new client for AdGroupCriterionLabelService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AdGroupCriterionLabelServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AdGroupCriterionLabelService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AdGroupCriterionLabelServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AdGroupCriterionLabelServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AdGroupCriterionLabelServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested ad group criterion label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel GetAdGroupCriterionLabel(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupCriterionLabel(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group criterion label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel GetAdGroupCriterionLabel(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAdGroupCriterionLabel, null, options, request);
      }
      /// <summary>
      /// Returns the requested ad group criterion label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAdGroupCriterionLabelAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested ad group criterion label in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupCriterionLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAdGroupCriterionLabel, null, options, request);
      }
      /// <summary>
      /// Creates and removes ad group criterion labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse MutateAdGroupCriterionLabels(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupCriterionLabels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes ad group criterion labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse MutateAdGroupCriterionLabels(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateAdGroupCriterionLabels, null, options, request);
      }
      /// <summary>
      /// Creates and removes ad group criterion labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabelsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateAdGroupCriterionLabelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes ad group criterion labels.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabelsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateAdGroupCriterionLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateAdGroupCriterionLabels, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AdGroupCriterionLabelServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AdGroupCriterionLabelServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AdGroupCriterionLabelServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetAdGroupCriterionLabel, serviceImpl.GetAdGroupCriterionLabel)
          .AddMethod(__Method_MutateAdGroupCriterionLabels, serviceImpl.MutateAdGroupCriterionLabels).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, AdGroupCriterionLabelServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetAdGroupCriterionLabel, serviceImpl.GetAdGroupCriterionLabel);
      serviceBinder.AddMethod(__Method_MutateAdGroupCriterionLabels, serviceImpl.MutateAdGroupCriterionLabels);
    }

  }
}
#endregion
