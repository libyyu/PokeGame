using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using SLua;
using UGUIEvent;

namespace FGame {

    [CustomLuaClass]
    public class LuaBehaviour : MonoBehaviour {
        private List<LuaFunction> buttons = new List<LuaFunction>();
        private LuaTable msgHandle = null;
        protected bool initialize = false;

        protected void Awake() {
            initialize = true;
            CallMethod("onAwake", gameObject);
        }

        protected void Start() {
            CallMethod("onStart");
        }

        protected void OnDestroy()
        {
            CallMethod("onDestroy");
            UnTouchGUIMsg();
            initialize = false;
        }
        /// <summary>
        /// 添加单击事件
        /// </summary>
        public void AddClick(GameObject go, LuaFunction luafunc) {
            if (go == null) return;
            buttons.Add(luafunc);
            go.GetComponent<Button>().onClick.AddListener(
                delegate() {
                    luafunc.call(go);
                }
            );
        }

        /// <summary>
        /// 清除单击事件
        /// </summary>
        public void ClearClick() {
            for (int i = 0; i < buttons.Count; i++) {
                if (buttons[i] != null) {
                    buttons[i].Dispose();
                    buttons[i] = null;
                }
            }
        }

        public void UnTouchGUIMsg()
        {
            ClearClick();
            DetachEventHandle();
            msgHandle = null;
        }

        public void TouchGUIMsg(LuaTable luaMsgHandler)
        {
            msgHandle = luaMsgHandler;
            AttachEventHandle();
        }

        [ContextMenu("UnTouchEvent")]
        public void DetachEventHandle()
        {
            UnTouchButton();
			UnTouchInputField ();
            UnTouchTweener();
            UnTouchScroll();
        }

        [ContextMenu("TouchEvent")]
        public void AttachEventHandle()
        {
            DetachEventHandle();
            TouchButton();
			TouchInputField ();
            TouchTweener();
            TouchScroll();
        }

        void TouchButton()
        {
            var comps = gameObject.GetComponentsInChildren<Button>(true);
            int Length = comps.Length;
            for(int i=0;i<Length;++i)
            {
                Button button = comps[i];
                EventClick.Get(button.gameObject).onClick += onClick;
            }
        }
        void UnTouchButton()
        {
            var comps = gameObject.GetComponentsInChildren<Button>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                Button button = comps[i];
                EventClick.Get(button.gameObject).onClick -= onClick;
            }
        }
		void TouchInputField()
		{
			var comps = gameObject.GetComponentsInChildren<InputField>(true);
			int Length = comps.Length;
			for(int i=0;i<Length;++i)
			{
				InputField inputfield = comps[i];
				EventEdit.Get(inputfield.gameObject).onSubmit += onSubmit;
                EventEdit.Get(inputfield.gameObject).onTextChange += onTextChange;
            }
		}
		void UnTouchInputField()
		{
			var comps = gameObject.GetComponentsInChildren<InputField>(true);
			int Length = comps.Length;
			for(int i=0;i<Length;++i)
			{
				InputField inputfield = comps[i];
                EventEdit.Get(inputfield.gameObject).onSubmit -= onSubmit;
                EventEdit.Get(inputfield.gameObject).onTextChange -= onTextChange;
            }
		}
        void TouchTweener()
        {
            var comps = gameObject.GetComponentsInChildren<UGUI.ITween>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                UGUI.ITween tweener = comps[i];
                tweener.onTweenFinish += onTweenFinish;
                tweener.onStepTweenFinish += onStepTweenFinish;
            }
        }
        void UnTouchTweener()
        {
            var comps = gameObject.GetComponentsInChildren<UGUI.ITween>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                UGUI.ITween tweener = comps[i];
                tweener.onTweenFinish -= onTweenFinish;
                tweener.onStepTweenFinish -= onStepTweenFinish;
            }
        }

        void TouchScroll()
        {
            var comps = gameObject.GetComponentsInChildren<Slider>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                Slider slider = comps[i];
                EventSlider.Get(slider.gameObject).onScroll += onScroll;
            }
        }
        void UnTouchScroll()
        {
            var comps = gameObject.GetComponentsInChildren<Slider>(true);
            int Length = comps.Length;
            for (int i = 0; i < Length; ++i)
            {
                Slider slider = comps[i];
                EventSlider.Get(slider.gameObject).onScroll -= onScroll;
            }
        }

        void onClick(GameObject go)
        {
            CallMethod("onClick",go);
        }

		void onSubmit(GameObject go,string str)
		{
			CallMethod("onSubmit",go,str);
		}

        void onTextChange(GameObject go,string str)
        {
            CallMethod("onTextChange", go, str);
        }

        void onTweenFinish(GameObject go)
        {
            CallMethod("onTweenFinish", go);
        }
        void onStepTweenFinish(GameObject go)
        {
            CallMethod("onStepTweenFinish", go);
        }
        void onScroll(GameObject go,float value)
        {
            CallMethod("onScroll", go,value);
        }

        /// <summary>
        /// 执行Lua方法
        /// </summary>
        object CallMethod(string func, params object[] args) {
            if (!initialize || null == msgHandle) return null;
            
			return msgHandle.safe_invoke (func, args);
        }

        //-----------------------------------------------------------------
    }
}