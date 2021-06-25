using System;

namespace AbstractFactory
{
    /// <summary>
    /// 果酱
    /// </summary>
    public interface Sauce
    {
        void Sauce();
    }
    /// <summary>
    /// 纽约果酱
    /// </summary>
    public class NYSauce : Sauce
    {
        public void Sauce()
        {
            Console.WriteLine("NYSauce");
        }
    }
    /// <summary>
    /// 芝加哥果酱
    /// </summary>
    public class ChicagoSauce : Sauce
    {
        public void Sauce()
        {
            Console.WriteLine("ChicagoSauce");
        }
    }

}