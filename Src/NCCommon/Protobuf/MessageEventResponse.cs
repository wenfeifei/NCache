//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MessageEventResponse.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MessageEventResponse")]
  public partial class MessageEventResponse : global::ProtoBuf.IExtensible
  {
    public MessageEventResponse() {}
    

    private string _MessageId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string MessageId
    {
      get { return _MessageId; }
      set { _MessageId = value; }
    }

    private int _failureReason = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"failureReason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int failureReason
    {
      get { return _failureReason; }
      set { _failureReason = value; }
    }

    private int _pubsubType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"pubsubType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int pubsubType
    {
      get { return _pubsubType; }
      set { _pubsubType = value; }
    }
    private readonly global::System.Collections.Generic.List<string> _subscriberIds = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"subscriberIds", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> subscriberIds
    {
      get { return _subscriberIds; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}