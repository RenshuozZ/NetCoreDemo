using System;

namespace Factory
{
    public abstract class Pizza
    {
        public string Name { get; set; }

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
           
        }

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
        public ApplePiePizza()
        {
            Name = "ApplePie";
        }
    }

    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese";
        }
    }

    public class SomeOtherPizza : Pizza
    {
        public SomeOtherPizza()
        {
            Name = "Other";
        }
    }
}