using System;

namespace MathMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(59/20):{0}", 59 / 20);
            Console.WriteLine("(60/20):{0}", 60 / 20);
            Console.WriteLine("(59%20):{0}", 59 % 20);
            Console.WriteLine("(60%20):{0}", 60 % 20);
            Console.WriteLine("(54/10):{0}", 54 / 10);
            Console.WriteLine("(56/10):{0}", 56 / 10);
            Console.WriteLine("(54.0%10.0):{0}", 54.0 % 10.0);
            Console.WriteLine("(56.0%10.0):{0}", 56.0 % 10.0);
            Console.WriteLine("Math.Celling(54.0/10.0):{0}", Math.Ceiling(54.0 / 10.0));
            Console.WriteLine("Math.Celling(56.0/10.0):{0}", Math.Ceiling(56.0 / 10.0));
            Console.WriteLine("Math.Floor(54.0/10.0):{0}", Math.Floor(54.0 / 10.0));
            Console.WriteLine("Math.Floor(56.0/10.0):{0}", Math.Floor(56.0 / 10.0));
            Console.ReadKey();
        }
    }
}
