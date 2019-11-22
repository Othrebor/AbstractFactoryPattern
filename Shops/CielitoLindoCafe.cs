namespace CoffeeWorld
{
    class CielitoLindoCafe : CoffeeFactory
    {
        public override ICoffee CreateCoffee(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor) => (coffeeType, coffeeFlavor) switch
        {
            (CoffeeType.Hot, CoffeeFlavor.Cappuccino) => new CLCappuccinoCoffee(coffeeType, coffeeFlavor),
            (_, _) => null
        };
    }
}