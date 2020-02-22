using System;

namespace XCMDEMO.Helpers
{
    public class Singleton<T> where T : class, new()
    {
        private static Lazy<T> _instance = new Lazy<T>(() => new T());

        private Singleton()
        {
        }

        public string HashCode
        {
            get
            {
                return _instance.Value.GetHashCode().ToString();
            }
        }

        public static T GetInstance()
        {
            return _instance.Value;
        }

        public static T Instance
        {
            get => _instance.Value;
        }

        public static T GetNewInstance()
        {
            _instance = new Lazy<T>(() => new T());
            return _instance.Value;
        }
    }
}