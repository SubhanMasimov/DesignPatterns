using System;

namespace SingletonDesignPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Singleton singleton1 = Singleton.GetSingleton();
            Singleton singleton2 = Singleton.GetSingleton();

            string result = singleton1.Equals(singleton2) ? "equals" : "not equals";

            Console.WriteLine(result);
        }
    }
}
