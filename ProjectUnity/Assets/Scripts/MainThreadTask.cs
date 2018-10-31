using System;
using System.Collections.Generic;
using System.Collections;
using System.Threading;
using UnityEngine;
using SLua;
/// <summary>
/// 工具类，让子线程可以在主线程中调用代码
/// </summary>
[CustomLuaClass]
public class MainThreadTask : MonoBehaviour
{
	private static MainThreadTask instance;
	void Awake()
	{
		instance = this;
		DontDestroyOnLoad (gameObject);
	}
	/// <summary>
	/// 必须在主线程中调用
	/// </summary>
	public static void Init()
	{
		if (m_inited)
			return;
		m_mainThreadID = Thread.CurrentThread.ManagedThreadId;
		var obj = new GameObject("MainThreadTask");
		obj.AddComponent<MainThreadTask>();
		m_inited = true;
	}

	static IEnumerator _InnerCall_(Action action)
	{
		action ();
		yield break;
	}
	public static void RunChildAsync(Action action)
	{
		if (!m_inited)
			Init ();
		instance.StartCoroutine (_InnerCall_ (action));
	}

	public static void RunInMainThread(Action action)
	{
		lock (m_taskQueue) {
			m_taskQueue.Enqueue (MakeCoroutineFromAction(action));
		}
	}

	public static void RunUntilFinish(Func<bool> condition, Action callback)
	{
		lock (m_taskQueue) {
			m_taskQueue.Enqueue (_WaitCall_(condition, callback));
		}
	}

	public static IEnumerator _WaitCall_(Func<bool> condition, Action action)
	{
		yield return new WaitUntil (condition);

		RunInMainThread (action);
	}

	private static IEnumerator MakeCoroutineFromAction(Action action)
	{
		action();
		yield break;
	}

	private static volatile Boolean m_inited = false;
	private static Int32 m_mainThreadID;
	private static Queue<IEnumerator> m_taskQueue = new Queue<IEnumerator>();
	private static volatile Boolean m_stopped = false;


	private void Update()
	{
		//start all queued task
		while (true)
		{
			Boolean hasMore = false;
			IEnumerator coroutine = null;
			lock (m_taskQueue)
			{
				if (m_taskQueue.Count > 0)
				{
					hasMore = true;
					coroutine = m_taskQueue.Dequeue();
				}
			}

			if (hasMore)
			{
				StartCoroutine(coroutine);
				continue;
			}
			else
			{
				break;
			}
		}
	}

	private void OnEnable()
	{
		m_stopped = false;
	}

	private void OnDisable()
	{
		m_stopped = true;
	}
}
