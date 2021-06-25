using System;
using System.Collections;

namespace ArrayListCapacity
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(arrayList.Capacity);
                arrayList.Add(i);
            }
            Console.ReadLine();
        }
    }
}
