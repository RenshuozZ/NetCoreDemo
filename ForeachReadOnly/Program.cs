using System;

namespace ForeachReadOnly
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStruct[] array = new MyStruct[] { new MyStruct { Name = "1" }, new MyStruct { Name = "2" } };
            //foreach (var item in array)
            //{
            //    item.Name = "3";
            //}
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Name = "3";
            }

            Console.ReadLine();
        }
    }
    struct MyStruct
    {
        public string Name { get; set; }
    }
}
