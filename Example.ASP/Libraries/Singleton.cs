﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Example.ASP.Libraries
{
    public abstract class Singleton<T> where T : class
    {
        private static readonly Lazy<T> sInstance = new Lazy<T>(() => CreateInstanceOfT());
        
        public static T Instance { get { return sInstance.Value; } }

        private static T CreateInstanceOfT()
        {
            return Activator.CreateInstance(typeof(T), true) as T;
        }
    }
}