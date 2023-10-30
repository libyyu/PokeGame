//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_GetChannelsLiveNoticeInfoSuccessCallbackResult : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult o;
			o=new WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult();
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
	static public int get_headUrl(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
	static public int get_noticeId(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.noticeId);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_noticeId(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.noticeId=v;
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
	static public int get_reservable(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.reservable);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_reservable(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.reservable=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_startTime(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.startTime);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_startTime(IntPtr l) {
		try {
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.startTime=v;
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
			WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult self=(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult)checkSelf(l);
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
		getTypeTable(l,"WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult");
		addMember(l,"headUrl",get_headUrl,set_headUrl,true);
		addMember(l,"nickname",get_nickname,set_nickname,true);
		addMember(l,"noticeId",get_noticeId,set_noticeId,true);
		addMember(l,"otherInfos",get_otherInfos,set_otherInfos,true);
		addMember(l,"reservable",get_reservable,set_reservable,true);
		addMember(l,"startTime",get_startTime,set_startTime,true);
		addMember(l,"status",get_status,set_status,true);
		addMember(l,"errMsg",get_errMsg,set_errMsg,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.GetChannelsLiveNoticeInfoSuccessCallbackResult));
	}
}
