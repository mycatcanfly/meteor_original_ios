//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LevelDatas.proto
namespace LevelDatas
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LevelDatastable")]
  public partial class LevelDatastable : global::ProtoBuf.IExtensible
  {
    public LevelDatastable() {}
    
    private string _tname = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"tname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string tname
    {
      get { return _tname; }
      set { _tname = value; }
    }
    private readonly global::System.Collections.Generic.List<LevelDatas> _tlist = new global::System.Collections.Generic.List<LevelDatas>();
    [global::ProtoBuf.ProtoMember(2, Name=@"tlist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<LevelDatas> tlist
    {
      get { return _tlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LevelDatas")]
  public partial class LevelDatas : global::ProtoBuf.IExtensible
  {
    public LevelDatas() {}
    
    private int _ID;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }
    private string _Scene;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Scene", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Scene
    {
      get { return _Scene; }
      set { _Scene = value; }
    }
    private bool _Template = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Template", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool Template
    {
      get { return _Template; }
      set { _Template = value; }
    }
    private bool _DisableFindWay = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DisableFindWay", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool DisableFindWay
    {
      get { return _DisableFindWay; }
      set { _DisableFindWay = value; }
    }
    private string _Name;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private int _LevelType = default(int);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"LevelType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int LevelType
    {
      get { return _LevelType; }
      set { _LevelType = value; }
    }
    private string _LevelScript = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"LevelScript", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string LevelScript
    {
      get { return _LevelScript; }
      set { _LevelScript = value; }
    }
    private string _BgmName = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"BgmName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BgmName
    {
      get { return _BgmName; }
      set { _BgmName = value; }
    }
    private string _StartScript = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"StartScript", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string StartScript
    {
      get { return _StartScript; }
      set { _StartScript = value; }
    }
    private string _sceneItems = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"sceneItems", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string sceneItems
    {
      get { return _sceneItems; }
      set { _sceneItems = value; }
    }
    private string _BgTexture = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"BgTexture", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BgTexture
    {
      get { return _BgTexture; }
      set { _BgTexture = value; }
    }
    private int _Pass = default(int);
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Pass", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Pass
    {
      get { return _Pass; }
      set { _Pass = value; }
    }
    private string _Param = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Param", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Param
    {
      get { return _Param; }
      set { _Param = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}