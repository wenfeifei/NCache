//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SurrogateResponse.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SurrogateResponse")]
  public partial class SurrogateResponse : global::ProtoBuf.IExtensible
  {
    public SurrogateResponse() {}
    

    private string _targetServer = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"targetServer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string targetServer
    {
      get { return _targetServer; }
      set { _targetServer = value; }
    }
    private readonly global::System.Collections.Generic.List<byte[]> _command = new global::System.Collections.Generic.List<byte[]>();
    [global::ProtoBuf.ProtoMember(2, Name=@"command", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<byte[]> command
    {
      get { return _command; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}