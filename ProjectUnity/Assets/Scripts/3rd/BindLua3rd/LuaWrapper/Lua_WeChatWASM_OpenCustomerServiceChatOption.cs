//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_OpenCustomerServiceChatOption : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption o;
			o=new WeChatWASM.OpenCustomerServiceChatOption();
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
	static public int get_corpId(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.corpId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_corpId(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.corpId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_extInfo(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.extInfo);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_extInfo(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			WeChatWASM.ExtInfoOption v;
			checkType(l,2,out v);
			self.extInfo=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_complete(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.complete=v;
			else if(op==1) self.complete+=v;
			else if(op==2) self.complete-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fail(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.fail=v;
			else if(op==1) self.fail+=v;
			else if(op==2) self.fail-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sendMessageImg(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sendMessageImg);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sendMessageImg(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.sendMessageImg=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sendMessagePath(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sendMessagePath);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sendMessagePath(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.sendMessagePath=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sendMessageTitle(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sendMessageTitle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sendMessageTitle(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.sendMessageTitle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_showMessageCard(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.showMessageCard);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_showMessageCard(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.Nullable<System.Boolean> v;
			checkNullable(l,2,out v);
			self.showMessageCard=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_success(IntPtr l) {
		try {
			WeChatWASM.OpenCustomerServiceChatOption self=(WeChatWASM.OpenCustomerServiceChatOption)checkSelf(l);
			System.Action<WeChatWASM.GeneralCallbackResult> v;
			int op=checkDelegate(l,2,out v);
			if(op==0) self.success=v;
			else if(op==1) self.success+=v;
			else if(op==2) self.success-=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.OpenCustomerServiceChatOption");
		addMember(l,"corpId",get_corpId,set_corpId,true);
		addMember(l,"extInfo",get_extInfo,set_extInfo,true);
		addMember(l,"complete",null,set_complete,true);
		addMember(l,"fail",null,set_fail,true);
		addMember(l,"sendMessageImg",get_sendMessageImg,set_sendMessageImg,true);
		addMember(l,"sendMessagePath",get_sendMessagePath,set_sendMessagePath,true);
		addMember(l,"sendMessageTitle",get_sendMessageTitle,set_sendMessageTitle,true);
		addMember(l,"showMessageCard",get_showMessageCard,set_showMessageCard,true);
		addMember(l,"success",null,set_success,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.OpenCustomerServiceChatOption));
	}
}
