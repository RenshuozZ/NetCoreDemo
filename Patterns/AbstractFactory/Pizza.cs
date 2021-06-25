using System;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        /// <summary>
        /// 面团
        /// </summary>
        public Dough Dough { get; set; }
        /// <summary>
        /// 酱汁
        /// </summary>
        public Sauce Sauce { get; set; }

        public abstract void Prepare();


        public void Cut()
        {
            Console.WriteLine($"Cutting the {Name}");
        }

        public void Bake()
        {
            Console.WriteLine($"Baking the {Name}");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing the {Name}");
        }
    }

    public class ApplePiePizza : Pizza
    {
        IPizzaIngredientFactory _pizzaIngredientFactory;
        public ApplePiePizza(IPizzaIngredientFactory pizzaIngredient)
        {
            this._pizzaIngredientFactory = pizzaIngredient;
            Name = "ApplePie";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing { Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Dough.Dough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Sauce.Sauce();
        }
    }

    public class CheesePizza : Pizza
    {
        IPizzaIngredientFactory _pizzaIngredientFactory;
        public CheesePizza(IPizzaIngredientFactory pizzaIngredient)
        {
            this._pizzaIngredientFactory = pizzaIngredient;
            Name = "Cheese";
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing { Name}");
            Dough = _pizzaIngredientFactory.CreateDough();
            Dough.Dough();
            Sauce = _pizzaIngredientFactory.CreateSauce();
            Sauce.Sauce();
        }
    }

    public class SomeOtherPizza : Pizza
    {
        public SomeOtherPizza()
        {
            Name = "Other";
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}