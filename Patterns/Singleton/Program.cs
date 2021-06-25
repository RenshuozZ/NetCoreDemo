using System;

//单例模式
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var a = Singleton5.GetSingleton();
            //var b = Singleton4.GetSingleton();
            //Singleton5.In();

            var c = Singleton6.GetSingleton();
            var d = Singleton6.GetSingleton();
        }
    }
}
