using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    /// <summary>
    /// 建造披萨原料工厂 接口
    /// </summary>
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
    }

    /// <summary>
    /// 纽约披萨工厂
    /// </summary>
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {           
            return new NYDough();
        }
        public Sauce CreateSauce()
        {
            return new NYSauce();
        }
    }

    /// <summary>
    /// 芝加哥披萨工厂
    /// </summary>
    public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ChicagoDough();
        }
        public Sauce CreateSauce()
        {
            return new ChicagoSauce();
        }
    }
}
