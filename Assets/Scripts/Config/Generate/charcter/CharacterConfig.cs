//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace Config.charcter
{
public sealed partial class CharacterConfig :  Bright.Config.BeanBase 
{
    public CharacterConfig(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        Name_l10n_key = _buf.ReadString(); Name = _buf.ReadString();
        Info = _buf.ReadString();
        PostInit();
    }

    public static CharacterConfig DeserializeCharacterConfig(ByteBuf _buf)
    {
        return new charcter.CharacterConfig(_buf);
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Name_l10n_key { get; }
    public string Info { get; private set; }

    public const int __ID__ = 471256817;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Tables _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
        Name = translator(Name_l10n_key, Name);
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Name:" + Name + ","
        + "Info:" + Info + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}