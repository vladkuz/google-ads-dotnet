// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/resources/customer_negative_criterion.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/resources/customer_negative_criterion.proto</summary>
  public static partial class CustomerNegativeCriterionReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/resources/customer_negative_criterion.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerNegativeCriterionReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkNnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJjZXMvY3VzdG9tZXJf",
            "bmVnYXRpdmVfY3JpdGVyaW9uLnByb3RvEiFnb29nbGUuYWRzLmdvb2dsZWFk",
            "cy52My5yZXNvdXJjZXMaLWdvb2dsZS9hZHMvZ29vZ2xlYWRzL3YzL2NvbW1v",
            "bi9jcml0ZXJpYS5wcm90bxoyZ29vZ2xlL2Fkcy9nb29nbGVhZHMvdjMvZW51",
            "bXMvY3JpdGVyaW9uX3R5cGUucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVo",
            "YXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8aHmdvb2ds",
            "ZS9wcm90b2J1Zi93cmFwcGVycy5wcm90bxocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90byL2BgoZQ3VzdG9tZXJOZWdhdGl2ZUNyaXRlcmlvbhJRCg1y",
            "ZXNvdXJjZV9uYW1lGAEgASgJQjrgQQX6QTQKMmdvb2dsZWFkcy5nb29nbGVh",
            "cGlzLmNvbS9DdXN0b21lck5lZ2F0aXZlQ3JpdGVyaW9uEiwKAmlkGAIgASgL",
            "MhsuZ29vZ2xlLnByb3RvYnVmLkludDY0VmFsdWVCA+BBAxJRCgR0eXBlGAMg",
            "ASgOMj4uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51bXMuQ3JpdGVyaW9u",
            "VHlwZUVudW0uQ3JpdGVyaW9uVHlwZUID4EEDEk4KDWNvbnRlbnRfbGFiZWwY",
            "BCABKAsyMC5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5jb21tb24uQ29udGVu",
            "dExhYmVsSW5mb0ID4EEFSAASWAoSbW9iaWxlX2FwcGxpY2F0aW9uGAUgASgL",
            "MjUuZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuY29tbW9uLk1vYmlsZUFwcGxp",
            "Y2F0aW9uSW5mb0ID4EEFSAASWQoTbW9iaWxlX2FwcF9jYXRlZ29yeRgGIAEo",
            "CzI1Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmNvbW1vbi5Nb2JpbGVBcHBD",
            "YXRlZ29yeUluZm9CA+BBBUgAEkcKCXBsYWNlbWVudBgHIAEoCzItLmdvb2ds",
            "ZS5hZHMuZ29vZ2xlYWRzLnYzLmNvbW1vbi5QbGFjZW1lbnRJbmZvQgPgQQVI",
            "ABJOCg15b3V0dWJlX3ZpZGVvGAggASgLMjAuZ29vZ2xlLmFkcy5nb29nbGVh",
            "ZHMudjMuY29tbW9uLllvdVR1YmVWaWRlb0luZm9CA+BBBUgAElIKD3lvdXR1",
            "YmVfY2hhbm5lbBgJIAEoCzIyLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLmNv",
            "bW1vbi5Zb3VUdWJlQ2hhbm5lbEluZm9CA+BBBUgAOoUB6kGBAQoyZ29vZ2xl",
            "YWRzLmdvb2dsZWFwaXMuY29tL0N1c3RvbWVyTmVnYXRpdmVDcml0ZXJpb24S",
            "S2N1c3RvbWVycy97Y3VzdG9tZXJ9L2N1c3RvbWVyTmVnYXRpdmVDcml0ZXJp",
            "YS97Y3VzdG9tZXJfbmVnYXRpdmVfY3JpdGVyaW9ufUILCgljcml0ZXJpb25C",
            "iwIKJWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5yZXNvdXJjZXNCHkN1",
            "c3RvbWVyTmVnYXRpdmVDcml0ZXJpb25Qcm90b1ABWkpnb29nbGUuZ29sYW5n",
            "Lm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvcmVz",
            "b3VyY2VzO3Jlc291cmNlc6ICA0dBQaoCIUdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYzLlJlc291cmNlc8oCIUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXFJlc291",
            "cmNlc+oCJUdvb2dsZTo6QWRzOjpHb29nbGVBZHM6OlYzOjpSZXNvdXJjZXNi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Common.CriteriaReflection.Descriptor, global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Resources.CustomerNegativeCriterion), global::Google.Ads.GoogleAds.V3.Resources.CustomerNegativeCriterion.Parser, new[]{ "ResourceName", "Id", "Type", "ContentLabel", "MobileApplication", "MobileAppCategory", "Placement", "YoutubeVideo", "YoutubeChannel" }, new[]{ "Criterion" }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A negative criterion for exclusions at the customer level.
  /// </summary>
  public sealed partial class CustomerNegativeCriterion : pb::IMessage<CustomerNegativeCriterion> {
    private static readonly pb::MessageParser<CustomerNegativeCriterion> _parser = new pb::MessageParser<CustomerNegativeCriterion>(() => new CustomerNegativeCriterion());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CustomerNegativeCriterion> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Resources.CustomerNegativeCriterionReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerNegativeCriterion() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerNegativeCriterion(CustomerNegativeCriterion other) : this() {
      resourceName_ = other.resourceName_;
      Id = other.Id;
      type_ = other.type_;
      switch (other.CriterionCase) {
        case CriterionOneofCase.ContentLabel:
          ContentLabel = other.ContentLabel.Clone();
          break;
        case CriterionOneofCase.MobileApplication:
          MobileApplication = other.MobileApplication.Clone();
          break;
        case CriterionOneofCase.MobileAppCategory:
          MobileAppCategory = other.MobileAppCategory.Clone();
          break;
        case CriterionOneofCase.Placement:
          Placement = other.Placement.Clone();
          break;
        case CriterionOneofCase.YoutubeVideo:
          YoutubeVideo = other.YoutubeVideo.Clone();
          break;
        case CriterionOneofCase.YoutubeChannel:
          YoutubeChannel = other.YoutubeChannel.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CustomerNegativeCriterion Clone() {
      return new CustomerNegativeCriterion(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. The resource name of the customer negative criterion.
    /// Customer negative criterion resource names have the form:
    ///
    /// `customers/{customer_id}/customerNegativeCriteria/{criterion_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 2;
    private static readonly pb::FieldCodec<long?> _single_id_codec = pb::FieldCodec.ForStructWrapper<long>(18);
    private long? id_;
    /// <summary>
    /// Output only. The ID of the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long? Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeEnum.Types.CriterionType type_ = 0;
    /// <summary>
    /// Output only. The type of the criterion.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeEnum.Types.CriterionType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "content_label" field.</summary>
    public const int ContentLabelFieldNumber = 4;
    /// <summary>
    /// Immutable. ContentLabel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.ContentLabelInfo ContentLabel {
      get { return criterionCase_ == CriterionOneofCase.ContentLabel ? (global::Google.Ads.GoogleAds.V3.Common.ContentLabelInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.ContentLabel;
      }
    }

    /// <summary>Field number for the "mobile_application" field.</summary>
    public const int MobileApplicationFieldNumber = 5;
    /// <summary>
    /// Immutable. MobileApplication.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.MobileApplicationInfo MobileApplication {
      get { return criterionCase_ == CriterionOneofCase.MobileApplication ? (global::Google.Ads.GoogleAds.V3.Common.MobileApplicationInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileApplication;
      }
    }

    /// <summary>Field number for the "mobile_app_category" field.</summary>
    public const int MobileAppCategoryFieldNumber = 6;
    /// <summary>
    /// Immutable. MobileAppCategory.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.MobileAppCategoryInfo MobileAppCategory {
      get { return criterionCase_ == CriterionOneofCase.MobileAppCategory ? (global::Google.Ads.GoogleAds.V3.Common.MobileAppCategoryInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.MobileAppCategory;
      }
    }

    /// <summary>Field number for the "placement" field.</summary>
    public const int PlacementFieldNumber = 7;
    /// <summary>
    /// Immutable. Placement.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.PlacementInfo Placement {
      get { return criterionCase_ == CriterionOneofCase.Placement ? (global::Google.Ads.GoogleAds.V3.Common.PlacementInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.Placement;
      }
    }

    /// <summary>Field number for the "youtube_video" field.</summary>
    public const int YoutubeVideoFieldNumber = 8;
    /// <summary>
    /// Immutable. YouTube Video.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.YouTubeVideoInfo YoutubeVideo {
      get { return criterionCase_ == CriterionOneofCase.YoutubeVideo ? (global::Google.Ads.GoogleAds.V3.Common.YouTubeVideoInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeVideo;
      }
    }

    /// <summary>Field number for the "youtube_channel" field.</summary>
    public const int YoutubeChannelFieldNumber = 9;
    /// <summary>
    /// Immutable. YouTube Channel.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Ads.GoogleAds.V3.Common.YouTubeChannelInfo YoutubeChannel {
      get { return criterionCase_ == CriterionOneofCase.YoutubeChannel ? (global::Google.Ads.GoogleAds.V3.Common.YouTubeChannelInfo) criterion_ : null; }
      set {
        criterion_ = value;
        criterionCase_ = value == null ? CriterionOneofCase.None : CriterionOneofCase.YoutubeChannel;
      }
    }

    private object criterion_;
    /// <summary>Enum of possible cases for the "criterion" oneof.</summary>
    public enum CriterionOneofCase {
      None = 0,
      ContentLabel = 4,
      MobileApplication = 5,
      MobileAppCategory = 6,
      Placement = 7,
      YoutubeVideo = 8,
      YoutubeChannel = 9,
    }
    private CriterionOneofCase criterionCase_ = CriterionOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CriterionOneofCase CriterionCase {
      get { return criterionCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearCriterion() {
      criterionCase_ = CriterionOneofCase.None;
      criterion_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CustomerNegativeCriterion);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CustomerNegativeCriterion other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (Id != other.Id) return false;
      if (Type != other.Type) return false;
      if (!object.Equals(ContentLabel, other.ContentLabel)) return false;
      if (!object.Equals(MobileApplication, other.MobileApplication)) return false;
      if (!object.Equals(MobileAppCategory, other.MobileAppCategory)) return false;
      if (!object.Equals(Placement, other.Placement)) return false;
      if (!object.Equals(YoutubeVideo, other.YoutubeVideo)) return false;
      if (!object.Equals(YoutubeChannel, other.YoutubeChannel)) return false;
      if (CriterionCase != other.CriterionCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (id_ != null) hash ^= Id.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.ContentLabel) hash ^= ContentLabel.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileApplication) hash ^= MobileApplication.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) hash ^= MobileAppCategory.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.Placement) hash ^= Placement.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) hash ^= YoutubeVideo.GetHashCode();
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) hash ^= YoutubeChannel.GetHashCode();
      hash ^= (int) criterionCase_;
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.ContentLabel) {
        output.WriteRawTag(34);
        output.WriteMessage(ContentLabel);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        output.WriteRawTag(42);
        output.WriteMessage(MobileApplication);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        output.WriteRawTag(50);
        output.WriteMessage(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        output.WriteRawTag(58);
        output.WriteMessage(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        output.WriteRawTag(66);
        output.WriteMessage(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        output.WriteRawTag(74);
        output.WriteMessage(YoutubeChannel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (criterionCase_ == CriterionOneofCase.ContentLabel) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContentLabel);
      }
      if (criterionCase_ == CriterionOneofCase.MobileApplication) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileApplication);
      }
      if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MobileAppCategory);
      }
      if (criterionCase_ == CriterionOneofCase.Placement) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Placement);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeVideo);
      }
      if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(YoutubeChannel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CustomerNegativeCriterion other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != 0L) {
          Id = other.Id;
        }
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      switch (other.CriterionCase) {
        case CriterionOneofCase.ContentLabel:
          if (ContentLabel == null) {
            ContentLabel = new global::Google.Ads.GoogleAds.V3.Common.ContentLabelInfo();
          }
          ContentLabel.MergeFrom(other.ContentLabel);
          break;
        case CriterionOneofCase.MobileApplication:
          if (MobileApplication == null) {
            MobileApplication = new global::Google.Ads.GoogleAds.V3.Common.MobileApplicationInfo();
          }
          MobileApplication.MergeFrom(other.MobileApplication);
          break;
        case CriterionOneofCase.MobileAppCategory:
          if (MobileAppCategory == null) {
            MobileAppCategory = new global::Google.Ads.GoogleAds.V3.Common.MobileAppCategoryInfo();
          }
          MobileAppCategory.MergeFrom(other.MobileAppCategory);
          break;
        case CriterionOneofCase.Placement:
          if (Placement == null) {
            Placement = new global::Google.Ads.GoogleAds.V3.Common.PlacementInfo();
          }
          Placement.MergeFrom(other.Placement);
          break;
        case CriterionOneofCase.YoutubeVideo:
          if (YoutubeVideo == null) {
            YoutubeVideo = new global::Google.Ads.GoogleAds.V3.Common.YouTubeVideoInfo();
          }
          YoutubeVideo.MergeFrom(other.YoutubeVideo);
          break;
        case CriterionOneofCase.YoutubeChannel:
          if (YoutubeChannel == null) {
            YoutubeChannel = new global::Google.Ads.GoogleAds.V3.Common.YouTubeChannelInfo();
          }
          YoutubeChannel.MergeFrom(other.YoutubeChannel);
          break;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 18: {
            long? value = _single_id_codec.Read(input);
            if (id_ == null || value != 0L) {
              Id = value;
            }
            break;
          }
          case 24: {
            Type = (global::Google.Ads.GoogleAds.V3.Enums.CriterionTypeEnum.Types.CriterionType) input.ReadEnum();
            break;
          }
          case 34: {
            global::Google.Ads.GoogleAds.V3.Common.ContentLabelInfo subBuilder = new global::Google.Ads.GoogleAds.V3.Common.ContentLabelInfo();
            if (criterionCase_ == CriterionOneofCase.ContentLabel) {
              subBuilder.MergeFrom(ContentLabel);
            }
            input.ReadMessage(subBuilder);
            ContentLabel = subBuilder;
            break;
          }
          case 42: {
            global::Google.Ads.GoogleAds.V3.Common.MobileApplicationInfo subBuilder = new global::Google.Ads.GoogleAds.V3.Common.MobileApplicationInfo();
            if (criterionCase_ == CriterionOneofCase.MobileApplication) {
              subBuilder.MergeFrom(MobileApplication);
            }
            input.ReadMessage(subBuilder);
            MobileApplication = subBuilder;
            break;
          }
          case 50: {
            global::Google.Ads.GoogleAds.V3.Common.MobileAppCategoryInfo subBuilder = new global::Google.Ads.GoogleAds.V3.Common.MobileAppCategoryInfo();
            if (criterionCase_ == CriterionOneofCase.MobileAppCategory) {
              subBuilder.MergeFrom(MobileAppCategory);
            }
            input.ReadMessage(subBuilder);
            MobileAppCategory = subBuilder;
            break;
          }
          case 58: {
            global::Google.Ads.GoogleAds.V3.Common.PlacementInfo subBuilder = new global::Google.Ads.GoogleAds.V3.Common.PlacementInfo();
            if (criterionCase_ == CriterionOneofCase.Placement) {
              subBuilder.MergeFrom(Placement);
            }
            input.ReadMessage(subBuilder);
            Placement = subBuilder;
            break;
          }
          case 66: {
            global::Google.Ads.GoogleAds.V3.Common.YouTubeVideoInfo subBuilder = new global::Google.Ads.GoogleAds.V3.Common.YouTubeVideoInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeVideo) {
              subBuilder.MergeFrom(YoutubeVideo);
            }
            input.ReadMessage(subBuilder);
            YoutubeVideo = subBuilder;
            break;
          }
          case 74: {
            global::Google.Ads.GoogleAds.V3.Common.YouTubeChannelInfo subBuilder = new global::Google.Ads.GoogleAds.V3.Common.YouTubeChannelInfo();
            if (criterionCase_ == CriterionOneofCase.YoutubeChannel) {
              subBuilder.MergeFrom(YoutubeChannel);
            }
            input.ReadMessage(subBuilder);
            YoutubeChannel = subBuilder;
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
