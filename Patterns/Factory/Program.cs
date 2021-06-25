using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new CheesePizzaFactory();
            Pizza cheesePizza = factory.CreatePizza();
            cheesePizza.Prepare();
            cheesePizza.Cut();
            cheesePizza.Bake();
            cheesePizza.Box();
            //输出：
            //Preparing Cheese
            //Cutting the Cheese
            //Baking the Cheese
            //Boxing the Cheese
        }
    }
}
