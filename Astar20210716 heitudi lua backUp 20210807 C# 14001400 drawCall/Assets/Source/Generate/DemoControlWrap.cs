﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DemoControlWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DemoControl), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("Awake", Awake);
		L.RegFunction("OnDestroy", OnDestroy);
		L.RegFunction("DrawPath", DrawPath);
		L.RegFunction("SaveDataToFile", SaveDataToFile);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("terrain", get_terrain, set_terrain);
		L.RegVar("G", get_G, set_G);
		L.RegVar("NUM_PER_SESS", get_NUM_PER_SESS, set_NUM_PER_SESS);
		L.RegVar("ifInverse", get_ifInverse, set_ifInverse);
		L.RegVar("debugGrid", get_debugGrid, set_debugGrid);
		L.RegVar("luaManager", get_luaManager, set_luaManager);
		L.RegVar("instance", get_instance, set_instance);
		L.RegVar("jpsHelper", get_jpsHelper, set_jpsHelper);
		L.RegConstant("mapWidth", 128);
		L.RegConstant("mapHeight", 128);
		L.RegVar("spos", get_spos, set_spos);
		L.RegVar("tpos", get_tpos, set_tpos);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Awake(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DemoControl obj = (DemoControl)ToLua.CheckObject<DemoControl>(L, 1);
			obj.Awake();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDestroy(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DemoControl obj = (DemoControl)ToLua.CheckObject<DemoControl>(L, 1);
			obj.OnDestroy();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int DrawPath(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			DemoControl obj = (DemoControl)ToLua.CheckObject<DemoControl>(L, 1);
			int[] arg0 = ToLua.CheckNumberArray<int>(L, 2);
			obj.DrawPath(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SaveDataToFile(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			DemoControl obj = (DemoControl)ToLua.CheckObject<DemoControl>(L, 1);
			obj.SaveDataToFile();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_terrain(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			UnityEngine.Terrain ret = obj.terrain;
			ToLua.PushSealed(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index terrain on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_G(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			int ret = obj.G;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index G on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_NUM_PER_SESS(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			int ret = obj.NUM_PER_SESS;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NUM_PER_SESS on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_ifInverse(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			bool ret = obj.ifInverse;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ifInverse on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_debugGrid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			DebugGrid ret = obj.debugGrid;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index debugGrid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			LuaManager ret = obj.luaManager;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index luaManager on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, DemoControl.instance);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_jpsHelper(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			ACE.JpsHelperManager ret = obj.jpsHelper;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index jpsHelper on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_spos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			string ret = obj.spos;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spos on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_tpos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			string ret = obj.tpos;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tpos on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_terrain(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			UnityEngine.Terrain arg0 = (UnityEngine.Terrain)ToLua.CheckObject(L, 2, typeof(UnityEngine.Terrain));
			obj.terrain = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index terrain on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_G(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.G = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index G on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_NUM_PER_SESS(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
			obj.NUM_PER_SESS = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index NUM_PER_SESS on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_ifInverse(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.ifInverse = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index ifInverse on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_debugGrid(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			DebugGrid arg0 = (DebugGrid)ToLua.CheckObject<DebugGrid>(L, 2);
			obj.debugGrid = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index debugGrid on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			LuaManager arg0 = (LuaManager)ToLua.CheckObject<LuaManager>(L, 2);
			obj.luaManager = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index luaManager on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_instance(IntPtr L)
	{
		try
		{
			DemoControl arg0 = (DemoControl)ToLua.CheckObject<DemoControl>(L, 2);
			DemoControl.instance = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_jpsHelper(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			ACE.JpsHelperManager arg0 = (ACE.JpsHelperManager)ToLua.CheckObject<ACE.JpsHelperManager>(L, 2);
			obj.jpsHelper = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index jpsHelper on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_spos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.spos = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index spos on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_tpos(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DemoControl obj = (DemoControl)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.tpos = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index tpos on a nil value");
		}
	}
}

