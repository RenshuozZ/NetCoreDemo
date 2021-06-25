namespace AbstractFactory
{
    /// <summary>
    /// 工厂接口
    /// </summary>
    interface IFactory
    {
        Pizza CreatePizza(IPizzaIngredientFactory pizzaIngredientFactory);
    }
    /// <summary>
    /// CheesePizza工厂方法
    /// </summary>
    public class CheesePizzaFactory : IFactory
    {
        public Pizza CreatePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            return new CheesePizza(pizzaIngredientFactory);

        }
    }

    /// <summary>
    /// ApplePiePizza工厂方法
    /// </summary>
    public class ApplePiePizzaFactory : IFactory
    {
        public Pizza CreatePizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            return new ApplePiePizza(pizzaIngredientFactory);
        }
    }
}
