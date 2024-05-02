// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: grpc/reflection/v1alpha/reflection.proto
// </auto-generated>
// Original file comments:
// Copyright 2016 gRPC authors.
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
// Service exported by server reflection
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Grpc.Reflection.V1Alpha {
  public static partial class ServerReflection
  {
    static readonly string __ServiceName = "grpc.reflection.v1alpha.ServerReflection";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest> __Marshaller_grpc_reflection_v1alpha_ServerReflectionRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Reflection.V1Alpha.ServerReflectionRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> __Marshaller_grpc_reflection_v1alpha_ServerReflectionResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> __Method_ServerReflectionInfo = new grpc::Method<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "ServerReflectionInfo",
        __Marshaller_grpc_reflection_v1alpha_ServerReflectionRequest,
        __Marshaller_grpc_reflection_v1alpha_ServerReflectionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Grpc.Reflection.V1Alpha.ReflectionReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ServerReflection</summary>
    [grpc::BindServiceMethod(typeof(ServerReflection), "BindService")]
    public abstract partial class ServerReflectionBase
    {
      /// <summary>
      /// The reflection service is structured as a bidirectional stream, ensuring
      /// all related requests go to a single server.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task ServerReflectionInfo(grpc::IAsyncStreamReader<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest> requestStream, grpc::IServerStreamWriter<global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ServerReflection</summary>
    public partial class ServerReflectionClient : grpc::ClientBase<ServerReflectionClient>
    {
      /// <summary>Creates a new client for ServerReflection</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServerReflectionClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ServerReflection that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ServerReflectionClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServerReflectionClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ServerReflectionClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// The reflection service is structured as a bidirectional stream, ensuring
      /// all related requests go to a single server.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> ServerReflectionInfo(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ServerReflectionInfo(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// The reflection service is structured as a bidirectional stream, ensuring
      /// all related requests go to a single server.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncDuplexStreamingCall<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse> ServerReflectionInfo(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_ServerReflectionInfo, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ServerReflectionClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ServerReflectionClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ServerReflectionBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ServerReflectionInfo, serviceImpl.ServerReflectionInfo).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ServerReflectionBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ServerReflectionInfo, serviceImpl == null ? null : new grpc::DuplexStreamingServerMethod<global::Grpc.Reflection.V1Alpha.ServerReflectionRequest, global::Grpc.Reflection.V1Alpha.ServerReflectionResponse>(serviceImpl.ServerReflectionInfo));
    }

  }
}
#endregion
