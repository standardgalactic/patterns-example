namespace Patterns.Creational.Singleton.Lazy; 
    internal  class LazyInstance{
        private static  Lazy<LazyInstance> _singleton = new (() => new LazyInstance());
        public static LazyInstance GetInstance() => _singleton.Value;
        private int _count;
        public int Count => ++_count;
        }

