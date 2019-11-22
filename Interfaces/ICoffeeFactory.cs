using System.Collections.Generic;

namespace CoffeeWorld
{
    public interface ICoffeeFactory
    {
        ICoffee CreateCoffee(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor);
    }
}