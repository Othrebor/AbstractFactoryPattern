using System.Collections.Generic;

namespace CoffeeWorld
{
    public abstract class CoffeeFactory : ICoffeeFactory
    {
        public abstract ICoffee CreateCoffee(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor);
    }
}