// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: communicator_objects/brain_type_proto.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from communicator_objects/brain_type_proto.proto</summary>
  public static partial class BrainTypeProtoReflection {

    #region Descriptor
    /// <summary>File descriptor for communicator_objects/brain_type_proto.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BrainTypeProtoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citjb21tdW5pY2F0b3Jfb2JqZWN0cy9icmFpbl90eXBlX3Byb3RvLnByb3Rv",
            "EhRjb21tdW5pY2F0b3Jfb2JqZWN0cxorY29tbXVuaWNhdG9yX29iamVjdHMv",
            "cmVzb2x1dGlvbl9wcm90by5wcm90bypHCg5CcmFpblR5cGVQcm90bxIKCgZQ",
            "bGF5ZXIQABINCglIZXVyaXN0aWMQARIMCghFeHRlcm5hbBACEgwKCEludGVy",
            "bmFsEANCH6oCHE1MQWdlbnRzLkNvbW11bmljYXRvck9iamVjdHNiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::MLAgents.CommunicatorObjects.ResolutionProtoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::MLAgents.CommunicatorObjects.BrainTypeProto), }, null));
    }
    #endregion

  }
  #region Enums
  public enum BrainTypeProto {
    [pbr::OriginalName("Player")] Player = 0,
    [pbr::OriginalName("Heuristic")] Heuristic = 1,
    [pbr::OriginalName("External")] External = 2,
    [pbr::OriginalName("Internal")] Internal = 3,
  }

  #endregion

}

#endregion Designer generated code
