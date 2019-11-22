using System;

namespace CoffeeWorld
{
    class SBCappuccinoCoffee : Coffee
    {
        public SBCappuccinoCoffee(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor) : base(coffeeType, coffeeFlavor)
        {
            PrepareCoffee();
        }

        public override void PrepareCoffee()
        {
            Console.WriteLine($"Preparing coffee: {Flavor}");
        }
    }
}