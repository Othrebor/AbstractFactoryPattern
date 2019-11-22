using System;

namespace CoffeeWorld
{
    class CLCappuccinoCoffee : Coffee
    {
        public CLCappuccinoCoffee(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor) : base(coffeeType, coffeeFlavor)
        {
            PrepareCoffee();
        }

        public override void PrepareCoffee()
        {
            Console.WriteLine($"Preparing coffee: {Flavor}");
        }
    }
}