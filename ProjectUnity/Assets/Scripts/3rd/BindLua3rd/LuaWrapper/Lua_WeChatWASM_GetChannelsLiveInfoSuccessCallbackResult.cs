//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetChannelsLiveInfoSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult o;
			o=new WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult();
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
	static public int get_description(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.description);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_description(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.description=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_feedId(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.feedId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_feedId(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.feedId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_headUrl(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.headUrl);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_headUrl(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.headUrl=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nickname(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nickname);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nickname(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.nickname=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_nonceId(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.nonceId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_nonceId(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.nonceId=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_otherInfos(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.otherInfos);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_otherInfos(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.String[] v;
			checkArray(l,2,out v);
			self.otherInfos=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_replayStatus(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.replayStatus);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_replayStatus(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.replayStatus=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_status(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.status);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_status(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.status=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_errMsg(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.errMsg);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_errMsg(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.errMsg=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult");
		addMember(l,"description",get_description,set_description,true);
		addMember(l,"feedId",get_feedId,set_feedId,true);
		addMember(l,"headUrl",get_headUrl,set_headUrl,true);
		addMember(l,"nickname",get_nickname,set_nickname,true);
		addMember(l,"nonceId",get_nonceId,set_nonceId,true);
		addMember(l,"otherInfos",get_otherInfos,set_otherInfos,true);
		addMember(l,"replayStatus",get_replayStatus,set_replayStatus,true);
		addMember(l,"status",get_status,set_status,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetChannelsLiveInfoSuccessCallbackResult));
	}
}
