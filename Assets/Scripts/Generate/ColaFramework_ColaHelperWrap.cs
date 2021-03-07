﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ColaFramework_ColaHelperWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("ColaHelper");
		L.RegVar("Update", get_Update, set_Update);
		L.RegVar("LateUpdate", get_LateUpdate, set_LateUpdate);
		L.RegVar("FixedUpdate", get_FixedUpdate, set_FixedUpdate);
		L.RegVar("OnApplicationQuit", get_OnApplicationQuit, set_OnApplicationQuit);
		L.RegVar("OnApplicationPause", get_OnApplicationPause, set_OnApplicationPause);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Update(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ColaFramework.ColaHelper.Update);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_LateUpdate(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ColaFramework.ColaHelper.LateUpdate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_FixedUpdate(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ColaFramework.ColaHelper.FixedUpdate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnApplicationQuit(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ColaFramework.ColaHelper.OnApplicationQuit);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_OnApplicationPause(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ColaFramework.ColaHelper.OnApplicationPause);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_Update(IntPtr L)
	{
		try
		{
			System.Action<float> arg0 = (System.Action<float>)ToLua.CheckDelegate<System.Action<float>>(L, 2);
			ColaFramework.ColaHelper.Update = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_LateUpdate(IntPtr L)
	{
		try
		{
			System.Action<float> arg0 = (System.Action<float>)ToLua.CheckDelegate<System.Action<float>>(L, 2);
			ColaFramework.ColaHelper.LateUpdate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_FixedUpdate(IntPtr L)
	{
		try
		{
			System.Action<float> arg0 = (System.Action<float>)ToLua.CheckDelegate<System.Action<float>>(L, 2);
			ColaFramework.ColaHelper.FixedUpdate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnApplicationQuit(IntPtr L)
	{
		try
		{
			System.Action arg0 = (System.Action)ToLua.CheckDelegate<System.Action>(L, 2);
			ColaFramework.ColaHelper.OnApplicationQuit = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_OnApplicationPause(IntPtr L)
	{
		try
		{
			System.Action<bool> arg0 = (System.Action<bool>)ToLua.CheckDelegate<System.Action<bool>>(L, 2);
			ColaFramework.ColaHelper.OnApplicationPause = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

