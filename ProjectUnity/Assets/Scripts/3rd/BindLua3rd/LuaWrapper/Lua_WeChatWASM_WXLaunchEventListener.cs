//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXLaunchEventListener : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXLaunchEventListener o;
			System.Action<WeChatWASM.LaunchEvent> a1 = default(System.Action<WeChatWASM.LaunchEvent>);
			checkDelegate(l,2,out a1);
			o=new WeChatWASM.WXLaunchEventListener(a1);
			pushValue(l,true);
			pushValue(l,o);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_OnLaunchProgressAction(IntPtr l) {
		try {
			WeChatWASM.WXLaunchEventListener self=(WeChatWASM.WXLaunchEventListener)checkSelf(l);
			System.Action<WeChatWASM.LaunchEvent> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.OnLaunchProgressAction=v;
			else if(op==1) self.OnLaunchProgressAction+=v;
			else if(op==2) self.OnLaunchProgressAction-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_Dict(IntPtr l) {
		try {
			pushValue(l,true);
			pushValue(l,WeChatWASM.WXLaunchEventListener.Dict);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_Dict(IntPtr l) {
		try {
			System.Collections.Generic.Dictionary<System.String,WeChatWASM.WXLaunchEventListener> v;
			checkType(l,2,out v);
			WeChatWASM.WXLaunchEventListener.Dict=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXLaunchEventListener");
		addMember(l,"OnLaunchProgressAction",null,set_OnLaunchProgressAction,true);
		addMember(l,"Dict",get_Dict,set_Dict,false);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXLaunchEventListener));
	}
}
