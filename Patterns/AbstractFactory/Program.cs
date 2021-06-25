using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();
            IFactory factory = new CheesePizzaFactory();
            Pizza cheesePizza = factory.CreatePizza(pizzaIngredientFactory);
            cheesePizza.Prepare();
            cheesePizza.Cut();
            cheesePizza.Bake();
            cheesePizza.Box();
            //输出：
            //Preparing Cheese
            //NYDough
            //NYSauce
            //Cutting the Cheese
            //Baking the Cheese
            //Boxing the Cheese
        }
    }
}
