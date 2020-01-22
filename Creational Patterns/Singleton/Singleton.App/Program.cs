namespace Singleton.App
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var singletonLazy1 = SingletonLazy.Instance;
            var singletonLazy2 = SingletonLazy.Instance;
            var singletonLazy3 = SingletonLazy.Instance;
            singletonLazy1.Test();
            singletonLazy2.Test();
            singletonLazy3.Test();

            var singletonDoubleCheck1 = SingletonDoubleCheckLock.Instance;
            var singletonDoubleCheck2 = SingletonDoubleCheckLock.Instance;
            var singletonDoubleCheck3 = SingletonDoubleCheckLock.Instance;
            singletonDoubleCheck3.Test();
            singletonDoubleCheck2.Test();
            singletonDoubleCheck1.Test();
        }
    }
}               