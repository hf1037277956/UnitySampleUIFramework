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
   
public partial class TbErrorCodeConfig
{
    private static TbErrorCodeConfig instance;
    public static TbErrorCodeConfig Instance
    {
        get
        {
            instance ??= Tables.Instance.TbErrorCodeConfig;
            return instance;
        }
    }

    private readonly Dictionary<int, common.ErrorCodeConfig> _dataMap;
    private readonly List<common.ErrorCodeConfig> _dataList;
    
    public TbErrorCodeConfig(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, common.ErrorCodeConfig>();
        _dataList = new List<common.ErrorCodeConfig>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            common.ErrorCodeConfig _v;
            _v = common.ErrorCodeConfig.DeserializeErrorCodeConfig(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public Dictionary<int, common.ErrorCodeConfig> DataMap => _dataMap;
    public List<common.ErrorCodeConfig> DataList => _dataList;

    public common.ErrorCodeConfig GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public common.ErrorCodeConfig Get(int key) => _dataMap[key];
    public common.ErrorCodeConfig this[int key] => _dataMap[key];

    public void Resolve(Tables _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    public void Clear()
    {
        instance = null;
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}