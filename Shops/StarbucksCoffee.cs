namespace CoffeeWorld
{
    class StarbucksCoffee : CoffeeFactory
    {
        public override ICoffee CreateCoffee(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor) => (coffeeType, coffeeFlavor) switch
        {
            (CoffeeType.Hot, CoffeeFlavor.Cappuccino) => new SBCappuccinoCoffee(coffeeType, coffeeFlavor),
            (_, _) => null
        };
    }
}