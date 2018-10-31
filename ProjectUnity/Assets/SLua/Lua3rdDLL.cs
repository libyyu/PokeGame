using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
#if !SLUA_STANDALONE
using UnityEngine;
#endif

namespace SLua{
	public static class Lua3rdDLL{
		static Dictionary<string, LuaCSFunction> DLLRegFuncs = new Dictionary<string, LuaCSFunction>();
		
		static Lua3rdDLL(){
            // LuaSocketDLL.Reg(DLLRegFuncs);
            //LuaPBDLL.reg(DLLRegFuncs);
            //LuaJsonDLL.reg(DLLRegFuncs);
            //LuaLPegDLL.reg(DLLRegFuncs);
        }
		
        public static void clear()
        {
            DLLRegFuncs.Clear();
        }

		public static void open(IntPtr L){
			
			Assembly assembly = null;
			foreach(var assem in AppDomain.CurrentDomain.GetAssemblies()){
				if(assem.GetName().Name == "Assembly-CSharp"){
					assembly = assem;
					break;
				}
			}
			if(assembly != null){
				var csfunctions = assembly.GetExportedTypes()
					.SelectMany(x => x.GetMethods(BindingFlags.Public|BindingFlags.Static) )
						.Where(y => y.IsDefined(typeof(LualibRegAttribute),false));

				foreach(MethodInfo func in csfunctions){
					var attr = System.Attribute.GetCustomAttribute(func,typeof(LualibRegAttribute)) as LualibRegAttribute;
					var csfunc = Delegate.CreateDelegate(typeof(LuaCSFunction),func) as LuaCSFunction;
                    LuaCSFunction tmpF = null;
                    if (!DLLRegFuncs.TryGetValue(attr.luaName, out tmpF))
                        DLLRegFuncs.Add(attr.luaName, csfunc);
                    else
                        DLLRegFuncs[attr.luaName] = csfunc;
				}
			}
			
			if(DLLRegFuncs.Count == 0){
				return;
			}
			
			LuaDLL.lua_getglobal(L, "package");
			LuaDLL.lua_getfield(L, -1, "preload");
			foreach (KeyValuePair<string, LuaCSFunction> pair in DLLRegFuncs) {
				LuaDLL.lua_pushcfunction (L, pair.Value);
				LuaDLL.lua_setfield(L, -2, pair.Key);
			}
			
			LuaDLL.lua_settop(L, 0);
		}


		[AttributeUsage(AttributeTargets.Method)]
		public class LualibRegAttribute:System.Attribute{

			public string luaName;
			public LualibRegAttribute(string luaName){
				this.luaName = luaName;
			}
		}
	}
}