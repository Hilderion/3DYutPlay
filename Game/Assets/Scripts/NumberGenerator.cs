using System;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace DefaultNamespace
{
    public class NumberGenerator
    {
        #region singleton
        private static NumberGenerator _instance;
        
        public static NumberGenerator Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new NumberGenerator();
                
                return _instance;
            }
        }
        
        private NumberGenerator()
        {
        }
        #endregion

        private int _number;

        public void Run()
        {
            for (int i = 0; i < 3; i++)
            {
                var args = OnNeumberGenratingForOut();
                _number += args.Interval;
                OnNeumberGenrated(_number);
            }
        }

        public NeumberGenratingEventArgs NeumberGenratingArgs { get; set; }

        private T Wait<T>(Func<T> func) where T : class, new()
        {
            Thread thread = new Thread(Start);
            var pair = new Pair(func);
            thread.Start(pair);
            thread.Join();
            return (T)pair.Result;
        }

        private class Pair
        {
            public Pair(Func<object> func)
            {
                Func = func;
            }

            public object Result { get; internal set; }
            public Func<object> Func { get; private set; }
        }

        private void Start(object arg)
        {
            var pair = (Pair) arg;
            
            int count = 0;
            while (count++ < 10)
//            while (true)
            {
                pair.Result = pair.Func();
                if (pair.Result != null)
                    break;
                
                Debug.Log("waiting " + count);
                Thread.Sleep(1000);
            }
        }

        private NeumberGenratingEventArgs Action()
        {
            return new NeumberGenratingEventArgs(2);
        }

        private T WaitCore<T>(Func<T> func) where T:class
        {
            int count = 0;
            while (count++ < 10)
//            while (true)
            {
                var args = func();
                if (args != null)
                    return args;
                
                Debug.Log("waiting " + count);
                Thread.Sleep(1000);
            }

            return default(T);
        }

        #region NeumberGenrating event things for C# 3.0
        public event EventHandler<NeumberGenratingEventArgs> NeumberGenrating;

        protected virtual void OnNeumberGenrating(NeumberGenratingEventArgs e)
        {
            if (NeumberGenrating != null)
                NeumberGenrating(this, e);
        }

        private NeumberGenratingEventArgs OnNeumberGenrating(int interval )
        {
            NeumberGenratingEventArgs args = new NeumberGenratingEventArgs(interval );
            OnNeumberGenrating(args);

            return args;
        }

        private Task<NeumberGenratingEventArgs> OnNeumberGenratingAsync()
        {
            return Task.Factory.StartNew(() => OnNeumberGenratingForOut());
        }

        private NeumberGenratingEventArgs OnNeumberGenratingForOut()
        {
            NeumberGenratingEventArgs args = new NeumberGenratingEventArgs();
            OnNeumberGenrating(args);

            return args;
        }

        public class NeumberGenratingEventArgs : EventArgs
        {
            public int Interval { get; set;} 

            public NeumberGenratingEventArgs()
            {
            }
	
            public NeumberGenratingEventArgs(int interval )
            {
                Interval = interval; 
            }
        }
        #endregion
        
        #region NeumberGenrated event things for C# 3.0
        public event EventHandler<NeumberGenratedEventArgs> NeumberGenrated;

        protected virtual void OnNeumberGenrated(NeumberGenratedEventArgs e)
        {
            if (NeumberGenrated != null)
                NeumberGenrated(this, e);
        }

        private NeumberGenratedEventArgs OnNeumberGenrated(int generatedNumber )
        {
            NeumberGenratedEventArgs args = new NeumberGenratedEventArgs(generatedNumber );
            OnNeumberGenrated(args);

            return args;
        }

        private NeumberGenratedEventArgs OnNeumberGenratedForOut()
        {
            NeumberGenratedEventArgs args = new NeumberGenratedEventArgs();
            OnNeumberGenrated(args);

            return args;
        }

        public class NeumberGenratedEventArgs : EventArgs
        {
            public int GeneratedNumber { get; set;} 

            public NeumberGenratedEventArgs()
            {
            }
	
            public NeumberGenratedEventArgs(int generatedNumber )
            {
                GeneratedNumber = generatedNumber; 
            }
        }
        #endregion
    }
}