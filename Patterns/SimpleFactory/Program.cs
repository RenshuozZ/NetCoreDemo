using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza cheesePizza = PizzaFactory.CreatePizza("cheese");
            cheesePizza.Prepare();
            cheesePizza.Cut();
            cheesePizza.Bake();
            cheesePizza.Box();
        }
    }
}
