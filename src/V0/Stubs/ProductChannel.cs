// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v0/enums/product_channel.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V0.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v0/enums/product_channel.proto</summary>
  public static partial class ProductChannelReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v0/enums/product_channel.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductChannelReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjNnb29nbGUvYWRzL2dvb2dsZWFkcy92MC9lbnVtcy9wcm9kdWN0X2NoYW5u",
            "ZWwucHJvdG8SHWdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYwLmVudW1zIlsKElBy",
            "b2R1Y3RDaGFubmVsRW51bSJFCg5Qcm9kdWN0Q2hhbm5lbBIPCgtVTlNQRUNJ",
            "RklFRBAAEgsKB1VOS05PV04QARIKCgZPTkxJTkUQAhIJCgVMT0NBTBADQsQB",
            "CiFjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjAuZW51bXNCE1Byb2R1Y3RD",
            "aGFubmVsUHJvdG9QAVpCZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29v",
            "Z2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YwL2VudW1zO2VudW1zogIDR0FBqgId",
            "R29vZ2xlLkFkcy5Hb29nbGVBZHMuVjAuRW51bXPKAh1Hb29nbGVcQWRzXEdv",
            "b2dsZUFkc1xWMFxFbnVtc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V0.Enums.ProductChannelEnum), global::Google.Ads.GoogleAds.V0.Enums.ProductChannelEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V0.Enums.ProductChannelEnum.Types.ProductChannel) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Locality of a product offer.
  /// </summary>
  public sealed partial class ProductChannelEnum : pb::IMessage<ProductChannelEnum> {
    private static readonly pb::MessageParser<ProductChannelEnum> _parser = new pb::MessageParser<ProductChannelEnum>(() => new ProductChannelEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductChannelEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V0.Enums.ProductChannelReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelEnum(ProductChannelEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductChannelEnum Clone() {
      return new ProductChannelEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductChannelEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductChannelEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductChannelEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProductChannelEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the locality of a product offer.
      /// </summary>
      public enum ProductChannel {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The item is sold online.
        /// </summary>
        [pbr::OriginalName("ONLINE")] Online = 2,
        /// <summary>
        /// The item is sold in local stores.
        /// </summary>
        [pbr::OriginalName("LOCAL")] Local = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code