//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_WXChatOnCallbackRes : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes o;
			o=new WeChatWASM.WXChatOnCallbackRes();
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
	static public int get_rawData(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rawData);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rawData(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.rawData=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_interactID(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.interactID);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_interactID(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.interactID=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_content(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.content);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_content(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.content=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_buttonText(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.buttonText);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_buttonText(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.buttonText=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_modalTitle(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.modalTitle);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_modalTitle(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.modalTitle=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_modalContent(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.modalContent);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_modalContent(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.modalContent=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_currentPlayerNumber(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.currentPlayerNumber);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_currentPlayerNumber(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.currentPlayerNumber=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_totalPlayerNumber(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.totalPlayerNumber);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_totalPlayerNumber(IntPtr l) {
		try {
			WeChatWASM.WXChatOnCallbackRes self=(WeChatWASM.WXChatOnCallbackRes)checkSelf(l);
			System.Nullable<System.Int32> v;
			checkNullable(l,2,out v);
			self.totalPlayerNumber=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.WXChatOnCallbackRes");
		addMember(l,"rawData",get_rawData,set_rawData,true);
		addMember(l,"interactID",get_interactID,set_interactID,true);
		addMember(l,"content",get_content,set_content,true);
		addMember(l,"buttonText",get_buttonText,set_buttonText,true);
		addMember(l,"modalTitle",get_modalTitle,set_modalTitle,true);
		addMember(l,"modalContent",get_modalContent,set_modalContent,true);
		addMember(l,"currentPlayerNumber",get_currentPlayerNumber,set_currentPlayerNumber,true);
		addMember(l,"totalPlayerNumber",get_totalPlayerNumber,set_totalPlayerNumber,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.WXChatOnCallbackRes));
	}
}
