using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Core
{
    public static class ServiceLocator
    {
        private static Dictionary<string, object> _instances = new Dictionary<string, object>();

        public static void Add<T>()
            where T : class, new()
        {
            _instances.Add(typeof(T).Name, new T());
        }
        public static void Add(object instance)
        {
            _instances.Add(instance.GetType().Name, instance);
        }
        public static void Add(string k, object instance)
        {
            _instances.Add(k, instance);
        }

        public static T Get<T>()
            where T : class
        {
            return _instances.Values.Where((s) => s is T).FirstOrDefault() as T;
        }
        public static T Get<T>(string key)
            where T : class
        {
            if (_instances.ContainsKey(key))
            {
                return _instances[key] as T;
            }
            return default(T);
        }
    }
}