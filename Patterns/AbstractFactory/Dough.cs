using System;

namespace AbstractFactory
{
    /// <summary>
    /// 面团
    /// </summary>
    public interface Dough
    {
        void Dough();
    }
    /// <summary>
    /// 纽约面团
    /// </summary>
    public class NYDough : Dough
    {
        public void Dough()
        {
            Console.WriteLine("NYDough");
        }
    }
    /// <summary>
    /// 芝加哥面团
    /// </summary>
    public class ChicagoDough : Dough
    {
        public void Dough()
        {
            Console.WriteLine("ChicagoDough");
        }
    }

    
}