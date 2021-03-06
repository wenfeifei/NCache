//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Dependency.proto
// Note: requires additional types generated from: Commands/KeyValue.proto
namespace Alachisoft.NCache.Common.Protobuf
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Dependency")]
  public partial class Dependency : global::ProtoBuf.IExtensible
  {
    public Dependency() {}
    
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyDependency> _keyDep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyDependency>();
    [global::ProtoBuf.ProtoMember(1, Name=@"keyDep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyDependency> keyDep
    {
      get { return _keyDep; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.FileDependency> _fileDep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.FileDependency>();
    [global::ProtoBuf.ProtoMember(2, Name=@"fileDep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.FileDependency> fileDep
    {
      get { return _fileDep; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OracleDependency> _oracleDep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OracleDependency>();
    [global::ProtoBuf.ProtoMember(3, Name=@"oracleDep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OracleDependency> oracleDep
    {
      get { return _oracleDep; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.YukonDependency> _yukonDep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.YukonDependency>();
    [global::ProtoBuf.ProtoMember(4, Name=@"yukonDep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.YukonDependency> yukonDep
    {
      get { return _yukonDep; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.Sql7Dependency> _sql7Dep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.Sql7Dependency>();
    [global::ProtoBuf.ProtoMember(5, Name=@"sql7Dep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.Sql7Dependency> sql7Dep
    {
      get { return _sql7Dep; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OleDbDependency> _oleDbDep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OleDbDependency>();
    [global::ProtoBuf.ProtoMember(6, Name=@"oleDbDep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OleDbDependency> oleDbDep
    {
      get { return _oleDbDep; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.ExtensibleDependency> _xtDep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.ExtensibleDependency>();
    [global::ProtoBuf.ProtoMember(7, Name=@"xtDep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.ExtensibleDependency> xtDep
    {
      get { return _xtDep; }
    }
  
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.NosDbDependency> _NosDep = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.NosDbDependency>();
    [global::ProtoBuf.ProtoMember(8, Name=@"NosDep", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.NosDbDependency> NosDep
    {
      get { return _NosDep; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"KeyDependency")]
  public partial class KeyDependency : global::ProtoBuf.IExtensible
  {
    public KeyDependency() {}
    
    private readonly global::System.Collections.Generic.List<string> _keys = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"keys", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> keys
    {
      get { return _keys; }
    }
  

    private long _startAfter = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"startAfter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long startAfter
    {
      get { return _startAfter; }
      set { _startAfter = value; }
    }

    private int _keyDependencyType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"keyDependencyType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int keyDependencyType
    {
      get { return _keyDependencyType; }
      set { _keyDependencyType = value; }
    }

    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FileDependency")]
  public partial class FileDependency : global::ProtoBuf.IExtensible
  {
    public FileDependency() {}
    
    private readonly global::System.Collections.Generic.List<string> _filePaths = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(1, Name=@"filePaths", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> filePaths
    {
      get { return _filePaths; }
    }
  

    private long _startAfter = default(long);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"startAfter", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long startAfter
    {
      get { return _startAfter; }
      set { _startAfter = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OracleDependency")]
  public partial class OracleDependency : global::ProtoBuf.IExtensible
  {
    public OracleDependency() {}
    

    private string _connectionString = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"connectionString", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string connectionString
    {
      get { return _connectionString; }
      set { _connectionString = value; }
    }

    private string _query = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"query", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string query
    {
      get { return _query; }
      set { _query = value; }
    }

    private int _commandType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"commandType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int commandType
    {
      get { return _commandType; }
      set { _commandType = value; }
    }
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OracleParam> _param = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OracleParam>();
    [global::ProtoBuf.ProtoMember(4, Name=@"param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.OracleParam> param
    {
      get { return _param; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OracleParam")]
  public partial class OracleParam : global::ProtoBuf.IExtensible
  {
    public OracleParam() {}
    

    private string _key = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.OracleCommandParam _cmdParam = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cmdParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.OracleCommandParam cmdParam
    {
      get { return _cmdParam; }
      set { _cmdParam = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OracleCommandParam")]
  public partial class OracleCommandParam : global::ProtoBuf.IExtensible
  {
    public OracleCommandParam() {}
    

    private int _dbType = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"dbType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dbType
    {
      get { return _dbType; }
      set { _dbType = value; }
    }

    private int _direction = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int direction
    {
      get { return _direction; }
      set { _direction = value; }
    }

    private string _value = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"YukonDependency")]
  public partial class YukonDependency : global::ProtoBuf.IExtensible
  {
    public YukonDependency() {}
    

    private string _connectionString = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"connectionString", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string connectionString
    {
      get { return _connectionString; }
      set { _connectionString = value; }
    }

    private string _query = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"query", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string query
    {
      get { return _query; }
      set { _query = value; }
    }

    private int _commandType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"commandType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int commandType
    {
      get { return _commandType; }
      set { _commandType = value; }
    }
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.YukonParam> _param = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.YukonParam>();
    [global::ProtoBuf.ProtoMember(4, Name=@"param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.YukonParam> param
    {
      get { return _param; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"YukonParam")]
  public partial class YukonParam : global::ProtoBuf.IExtensible
  {
    public YukonParam() {}
    

    private string _key = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"key", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string key
    {
      get { return _key; }
      set { _key = value; }
    }

    private Alachisoft.NCache.Common.Protobuf.YukonCommandParam _cmdParam = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"cmdParam", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Alachisoft.NCache.Common.Protobuf.YukonCommandParam cmdParam
    {
      get { return _cmdParam; }
      set { _cmdParam = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"YukonCommandParam")]
  public partial class YukonCommandParam : global::ProtoBuf.IExtensible
  {
    public YukonCommandParam() {}
    

    private int _typeId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"typeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int typeId
    {
      get { return _typeId; }
      set { _typeId = value; }
    }

    private int _direction = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"direction", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int direction
    {
      get { return _direction; }
      set { _direction = value; }
    }

    private int _dbType = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"dbType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int dbType
    {
      get { return _dbType; }
      set { _dbType = value; }
    }

    private int _cmpOptions = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"cmpOptions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int cmpOptions
    {
      get { return _cmpOptions; }
      set { _cmpOptions = value; }
    }

    private int _version = default(int);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"version", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int version
    {
      get { return _version; }
      set { _version = value; }
    }

    private string _value = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string value
    {
      get { return _value; }
      set { _value = value; }
    }

    private bool _isNullable = default(bool);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"isNullable", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool isNullable
    {
      get { return _isNullable; }
      set { _isNullable = value; }
    }

    private int _localeId = default(int);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"localeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int localeId
    {
      get { return _localeId; }
      set { _localeId = value; }
    }

    private int _offset = default(int);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"offset", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int offset
    {
      get { return _offset; }
      set { _offset = value; }
    }

    private int _precision = default(int);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"precision", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int precision
    {
      get { return _precision; }
      set { _precision = value; }
    }

    private int _scale = default(int);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"scale", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int scale
    {
      get { return _scale; }
      set { _scale = value; }
    }

    private int _size = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"size", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int size
    {
      get { return _size; }
      set { _size = value; }
    }

    private string _sourceColumn = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"sourceColumn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sourceColumn
    {
      get { return _sourceColumn; }
      set { _sourceColumn = value; }
    }

    private bool _sourceColumnNull = default(bool);
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"sourceColumnNull", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool sourceColumnNull
    {
      get { return _sourceColumnNull; }
      set { _sourceColumnNull = value; }
    }

    private string _sqlValue = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"sqlValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sqlValue
    {
      get { return _sqlValue; }
      set { _sqlValue = value; }
    }

    private string _typeName = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"typeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string typeName
    {
      get { return _typeName; }
      set { _typeName = value; }
    }

    private string _udtTypeName = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"udtTypeName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string udtTypeName
    {
      get { return _udtTypeName; }
      set { _udtTypeName = value; }
    }

    private bool _nullValueProvided = default(bool);
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"nullValueProvided", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool nullValueProvided
    {
      get { return _nullValueProvided; }
      set { _nullValueProvided = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Sql7Dependency")]
  public partial class Sql7Dependency : global::ProtoBuf.IExtensible
  {
    public Sql7Dependency() {}
    

    private string _connectionString = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"connectionString", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string connectionString
    {
      get { return _connectionString; }
      set { _connectionString = value; }
    }

    private string _dbCacheKey = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"dbCacheKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dbCacheKey
    {
      get { return _dbCacheKey; }
      set { _dbCacheKey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OleDbDependency")]
  public partial class OleDbDependency : global::ProtoBuf.IExtensible
  {
    public OleDbDependency() {}
    

    private string _connectionString = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"connectionString", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string connectionString
    {
      get { return _connectionString; }
      set { _connectionString = value; }
    }

    private string _dbCacheKey = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"dbCacheKey", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string dbCacheKey
    {
      get { return _dbCacheKey; }
      set { _dbCacheKey = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExtensibleDependency")]
  public partial class ExtensibleDependency : global::ProtoBuf.IExtensible
  {
    public ExtensibleDependency() {}
    

    private byte[] _data = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] data
    {
      get { return _data; }
      set { _data = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NosDbDependency")]
  public partial class NosDbDependency : global::ProtoBuf.IExtensible
  {
    public NosDbDependency() {}
    

    private string _connectionString = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"connectionString", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string connectionString
    {
      get { return _connectionString; }
      set { _connectionString = value; }
    }

    private string _query = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"query", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string query
    {
      get { return _query; }
      set { _query = value; }
    }

    private int _timeout = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"timeout", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int timeout
    {
      get { return _timeout; }
      set { _timeout = value; }
    }
    private readonly global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValue> _param = new global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValue>();
    [global::ProtoBuf.ProtoMember(4, Name=@"param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Alachisoft.NCache.Common.Protobuf.KeyValue> param
    {
      get { return _param; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}