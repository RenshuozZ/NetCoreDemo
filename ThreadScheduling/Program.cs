using System;
using System.Threading;

namespace ThreadScheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 101, 65, 5445, 1, 152, 990 };
            foreach (var item in numbers)
            {
                new Thread(new ThreadStart(delegate () 
                {
                    Thread.Sleep(item);
                    Console.WriteLine(item);
                })).Start();

            }
            Console.ReadLine();
        }
    }
}
