using System;

namespace SingletonDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetSingleton();
            Singleton singleton2 = Singleton.GetSingleton();

            string result = singleton1.Equals(singleton2) ? "equals" : "not equals";

            Console.WriteLine(result);
        }
    }

    class Singleton
    {
        private static Singleton _singleton;

        private Singleton() { }

        public static Singleton GetSingleton()
        {
            return _singleton == null ? _singleton = new Singleton() : _singleton;
        }
    }
}
