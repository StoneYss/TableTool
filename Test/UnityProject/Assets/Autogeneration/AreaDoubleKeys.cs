/*
 * 生成时间：2015/6/26 12:18
 * 表格文件：AreaDoubleKeys.xls
 * 检索关键字段：ID type 
 * 忽略字段：param2 
 */
using System.Collections;
using System.Collections.Generic;
namespace TableTool
{
public struct AreaDoubleKeysKey
{
    /// <summary>
    /// 区域ID
    /// 多行测试
    /// </summary>
    public int ID;
    /// <summary>
    /// 类型
    /// </summary>
    public typeEnum type;
}
public struct AreaDoubleKeysData
{
    /// <summary>
    /// 区域ID
    /// 多行测试
    /// </summary>
    public int ID;
    /// <summary>
    /// 类型
    /// </summary>
    public typeEnum type;
    /// <summary>
    /// 描述
    /// </summary>
    public string Des;
    /// <summary>
    /// 中心格 X
    /// </summary>
    public int coordinate_x;
    /// <summary>
    /// 中心格 Y
    /// </summary>
    public float coordinate_y;
    /// <summary>
    /// 参数1
    /// </summary>
    public long param1;
    /// <summary>
    /// 获取key
    /// </summary>
    public AreaDoubleKeysKey GetKey()
    {
		var key = new AreaDoubleKeysKey();
		key.ID = ID;
		key.type = type;
        return key;
    }
}
public enum typeEnum
{
	Empty=0,
	All=1,
	Half=2
}
public class AreaDoubleKeysManager
{
    private static Dictionary<AreaDoubleKeysKey, AreaDoubleKeysData> mData = new Dictionary<AreaDoubleKeysKey, AreaDoubleKeysData>();
    /// <summary>
    /// 表数据
    /// </summary>
    public static Dictionary<AreaDoubleKeysKey, AreaDoubleKeysData> data { get { return mData; } }
    /// <summary>
    /// 清除所有数据
    /// </summary>
    public static void Clear()
    {
        mData.Clear();
    }
    /// <summary>
    /// 添加成员
    /// </summary>
    public static void AddItem(AreaDoubleKeysData item)
    {
        var key = item.GetKey();
        mData.Add(key, item);
    }
    /// <summary>
    /// 获取数据
    /// </summary>
    public static AreaDoubleKeysData GetItem(int ID, typeEnum type)
    {
		var key = new AreaDoubleKeysKey();
		key.ID = ID;
		key.type = type;
        return mData[key];
    }
}
}
