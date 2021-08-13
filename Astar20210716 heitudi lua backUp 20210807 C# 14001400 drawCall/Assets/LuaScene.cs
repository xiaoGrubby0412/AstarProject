using LuaInterface;
using UnityEngine;

public class LuaScene : MonoBehaviour
{

    string luaString = @"
                        print('这是一个使用DoString的Lua程序')
                                        ";
    string luaFile = "requires";
    LuaState state;


    void Start()
    {

        state = new LuaState();//建立Lua虚拟机
        state.Start();//启动虚拟机

        //使用string调用Lua
        state.DoString(luaString);

        //使用文件调用Lua
        //手动添加一个lua文件搜索地址
        string sceneFile = Application.dataPath + "/LuaScript";
        state.AddSearchPath(sceneFile);
        state.Require(luaFile);

        state["num"] = 10;

        LuaFunction luaFunc = state.GetFunction("Count");
        luaFunc.Call();
        Debug.Log("C#调用LuaFunc,函数返回值：" + state["num"]);

        Debug.Log("C#直接调用Count方法。");
        state.Call("Count", false);

        LuaFunction valueFunc = state.GetFunction("InputValue");
        valueFunc.BeginPCall();
        valueFunc.Push("--push方法从C#中传入参数--");
        valueFunc.PCall();
        valueFunc.EndPCall();
        valueFunc.Call("--直接Call方法从C#传入参数--");

        LuaTable table = state.GetTable("mytable");
        table.Call("tableFunc");
        LuaFunction tableFunc = table.GetLuaFunction("tableFunc");
        Debug.Log("C#调用table中的func");
        tableFunc.Call();
        Debug.Log("获取table中的num值：" + table["num"]);

        //通过下标直接获取
        for (int i = 1; i <= table.Length; i++)
        {
            Debug.Log("获取table的值：" + table[i]);
        }

        //转换成LuaDictTable
        LuaDictTable dicTable = table.ToDictTable();
        foreach (var item in dicTable)
        {
            Debug.LogFormat("遍历table:{0}--{1}", item.Key, item.Value);
        }
        //state.Dispose();//使用完毕回收虚拟机
        //Debug.LogFormat("当前虚拟机状态：{0}", null == state);//验证虚拟机状态
    }

}