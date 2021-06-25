namespace SimpleFactory
{
    /// <summary>
    /// pizza创建工厂
    /// </summary>
    public class PizzaFactory
    {
        public static Pizza CreatePizza(string pizzaType)
        {
            switch (pizzaType)
            {
                case "Cheese":
                    return new CheesePizza();
                case "ApplePie":
                    return new ApplePiePizza();
                default:
                    return new SomeOtherPizza();
            }
        }
    }
}
