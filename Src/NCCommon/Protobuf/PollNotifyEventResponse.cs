//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: PollNotifyEventResponse.proto
// Note: requires additional types generated from: EventId.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PollNotifyEventResponse")]
  public partial class PollNotifyEventResponse : global::ProtoBuf.IExtensible
  {
    public PollNotifyEventResponse() {}
    

    private int _callbackId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"callbackId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int callbackId
    {
      get { return _callbackId; }
      set { _callbackId = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.EventId _eventId = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"eventId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.EventId eventId
    {
      get { return _eventId; }
      set { _eventId = value; }
    }

    private int _eventType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"eventType", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int eventType
    {
      get { return _eventType; }
      set { _eventType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
