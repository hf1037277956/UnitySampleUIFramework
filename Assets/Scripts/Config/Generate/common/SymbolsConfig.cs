//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;


namespace Config.common
{
public sealed partial class SymbolsConfig :  Bright.Config.BeanBase 
{
    public SymbolsConfig(ByteBuf _buf) 
    {
        Symbol = _buf.ReadString();
        PostInit();
    }

    public static SymbolsConfig DeserializeSymbolsConfig(ByteBuf _buf)
    {
        return new common.SymbolsConfig(_buf);
    }

    public string Symbol { get; private set; }

    public const int __ID__ = 83098138;
    public override int GetTypeId() => __ID__;

    public  void Resolve(Tables _tables)
    {
        PostResolve();
    }

    public  void TranslateText(System.Func<string, string, string> translator)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Symbol:" + Symbol + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}