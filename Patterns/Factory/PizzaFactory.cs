namespace Factory
{
    /// <summary>
    /// CheesePizza工厂方法
    /// </summary>
    public class CheesePizzaFactory : IFactory
    {
        public Pizza CreatePizza()
        {
            return new CheesePizza();

        }
    }

    /// <summary>
    /// ApplePiePizza工厂方法
    /// </summary>
    public class ApplePiePizzaFactory : IFactory
    {
        public Pizza CreatePizza()
        {
            return new ApplePiePizza();
        }
    }
}
