//Auto Generate By LuaInterface, Do Not Edit!
using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_WeChatWASM_RequestProfile : LuaObject {
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
		try {
			WeChatWASM.RequestProfile o;
			o=new WeChatWASM.RequestProfile();
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
	static public int get_SSLconnectionEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SSLconnectionEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_SSLconnectionEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.SSLconnectionEnd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_SSLconnectionStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.SSLconnectionStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_SSLconnectionStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.SSLconnectionStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_connectEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connectEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_connectEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.connectEnd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_connectStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.connectStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_connectStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.connectStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_domainLookUpEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.domainLookUpEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_domainLookUpEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.domainLookUpEnd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_domainLookUpStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.domainLookUpStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_domainLookUpStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.domainLookUpStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_downstreamThroughputKbpsEstimate(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.downstreamThroughputKbpsEstimate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_downstreamThroughputKbpsEstimate(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.downstreamThroughputKbpsEstimate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_estimate_nettype(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.estimate_nettype);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_estimate_nettype(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.estimate_nettype=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_fetchStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.fetchStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_fetchStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.fetchStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_httpRttEstimate(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.httpRttEstimate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_httpRttEstimate(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.httpRttEstimate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_peerIP(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.peerIP);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_peerIP(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.peerIP=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_port(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.port);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_port(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.port=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_protocol(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.protocol);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_protocol(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.String v;
			checkType(l,2,out v);
			self.protocol=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_receivedBytedCount(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.receivedBytedCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_receivedBytedCount(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.receivedBytedCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_redirectEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.redirectEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_redirectEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.redirectEnd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_redirectStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.redirectStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_redirectStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.redirectStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_requestEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.requestEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_requestEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.requestEnd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_requestStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.requestStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_requestStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.requestStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_responseEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.responseEnd);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_responseEnd(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.responseEnd=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_responseStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.responseStart);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_responseStart(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Int64 v;
			checkType(l,2,out v);
			self.responseStart=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_rtt(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.rtt);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_rtt(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.rtt=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_sendBytesCount(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.sendBytesCount);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_sendBytesCount(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.sendBytesCount=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_socketReused(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.socketReused);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_socketReused(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Boolean v;
			checkType(l,2,out v);
			self.socketReused=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_throughputKbps(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.throughputKbps);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_throughputKbps(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.throughputKbps=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_transportRttEstimate(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			pushValue(l,true);
			pushValue(l,self.transportRttEstimate);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int set_transportRttEstimate(IntPtr l) {
		try {
			WeChatWASM.RequestProfile self=(WeChatWASM.RequestProfile)checkSelf(l);
			System.Double v;
			checkType(l,2,out v);
			self.transportRttEstimate=v;
			pushValue(l,true);
			return 1;
		}
		catch(Exception e) {
			return error(l,e);
		}
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"WeChatWASM.RequestProfile");
		addMember(l,"SSLconnectionEnd",get_SSLconnectionEnd,set_SSLconnectionEnd,true);
		addMember(l,"SSLconnectionStart",get_SSLconnectionStart,set_SSLconnectionStart,true);
		addMember(l,"connectEnd",get_connectEnd,set_connectEnd,true);
		addMember(l,"connectStart",get_connectStart,set_connectStart,true);
		addMember(l,"domainLookUpEnd",get_domainLookUpEnd,set_domainLookUpEnd,true);
		addMember(l,"domainLookUpStart",get_domainLookUpStart,set_domainLookUpStart,true);
		addMember(l,"downstreamThroughputKbpsEstimate",get_downstreamThroughputKbpsEstimate,set_downstreamThroughputKbpsEstimate,true);
		addMember(l,"estimate_nettype",get_estimate_nettype,set_estimate_nettype,true);
		addMember(l,"fetchStart",get_fetchStart,set_fetchStart,true);
		addMember(l,"httpRttEstimate",get_httpRttEstimate,set_httpRttEstimate,true);
		addMember(l,"peerIP",get_peerIP,set_peerIP,true);
		addMember(l,"port",get_port,set_port,true);
		addMember(l,"protocol",get_protocol,set_protocol,true);
		addMember(l,"receivedBytedCount",get_receivedBytedCount,set_receivedBytedCount,true);
		addMember(l,"redirectEnd",get_redirectEnd,set_redirectEnd,true);
		addMember(l,"redirectStart",get_redirectStart,set_redirectStart,true);
		addMember(l,"requestEnd",get_requestEnd,set_requestEnd,true);
		addMember(l,"requestStart",get_requestStart,set_requestStart,true);
		addMember(l,"responseEnd",get_responseEnd,set_responseEnd,true);
		addMember(l,"responseStart",get_responseStart,set_responseStart,true);
		addMember(l,"rtt",get_rtt,set_rtt,true);
		addMember(l,"sendBytesCount",get_sendBytesCount,set_sendBytesCount,true);
		addMember(l,"socketReused",get_socketReused,set_socketReused,true);
		addMember(l,"throughputKbps",get_throughputKbps,set_throughputKbps,true);
		addMember(l,"transportRttEstimate",get_transportRttEstimate,set_transportRttEstimate,true);
		createTypeMetatable(l,constructor, typeof(WeChatWASM.RequestProfile));
	}
}
