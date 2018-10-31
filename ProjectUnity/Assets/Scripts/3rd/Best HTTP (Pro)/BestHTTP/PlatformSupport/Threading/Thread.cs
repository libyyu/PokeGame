/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

using System;
using System.Threading;

#if NETFX_CORE
using System.Threading.Tasks;
#endif

namespace LegacySystem
{

    public delegate void ParameterizedThreadStart(object target);
    public delegate void ThreadStart();

    public class Thread
    {

        /*
         * pretty sure Task.Start doesn't always spin up a new thread (depends on synccontext)
         * pretty sure that we'll need try/catching as tasks can throw exceptions when their state isn't as expected (e.g. waiting on a completed task?)
         * */

#if NETFX_CORE
        private ParameterizedThreadStart _paramThreadStart;
        private ThreadStart _threadStart;
#endif

#if NETFX_CORE

        private Task _task = null;
        private CancellationTokenSource _taskCancellationTokenSource;
#endif

        /// <summary>
        /// Currently this value is ignored, not sure how to implement this
        /// </summary>
        public bool IsBackground
        {
            get { return true; }
            set { throw new NotImplementedException("currently always on background"); }
        }

        public Thread(ThreadStart start)
        {
#if NETFX_CORE
            _taskCancellationTokenSource = new CancellationTokenSource();
            _threadStart = start;
#else
            throw new NotSupportedException();
#endif
        }

        public Thread(ParameterizedThreadStart start)
        {
#if NETFX_CORE
            _taskCancellationTokenSource = new CancellationTokenSource();
            _paramThreadStart = start;
#else
            throw new NotSupportedException();
#endif
        }

        public void Abort()
        {
#if NETFX_CORE
            if (_taskCancellationTokenSource != null)
            { 
                _taskCancellationTokenSource.Cancel();
            }
#else
            throw new NotSupportedException();
#endif
        }

        public bool Join(int ms)
        {
#if NETFX_CORE
            EnsureTask();
            return _task.Wait(ms, _taskCancellationTokenSource.Token);
#else
            throw new NotSupportedException();
#endif
        }

        public void Start()
        {
#if NETFX_CORE
            EnsureTask();
            _task.Start(TaskScheduler.Default);
#else
            throw new NotSupportedException();
#endif
        }

        public void Start(Object param)
        {
#if NETFX_CORE
            EnsureTask(param);
            _task.Start(TaskScheduler.Default);
#else
            throw new NotSupportedException();
#endif
        }

#if NETFX_CORE
        /// <summary>
        /// Ensures the underlying Task is created and initialized correctly
        /// </summary>
        /// <param name="paramThreadStartParam"></param>
        private void EnsureTask(object paramThreadStartParam = null)
        {
            if (_task == null)
            { 
                if (_paramThreadStart != null)
                {
                    _task = new Task(() => _paramThreadStart(paramThreadStartParam), _taskCancellationTokenSource.Token);
                }
                else if (_threadStart != null)
                {
                    _task = new Task(() => _threadStart(), _taskCancellationTokenSource.Token);
                }
            }
        }
#endif

        public static void Sleep(int ms)
        {
#if NETFX_CORE
            new ManualResetEvent(false).WaitOne(ms);
#else
            throw new NotSupportedException();
#endif
        }
    }

    public class ThreadAbortException : Exception
    {

    }

}
