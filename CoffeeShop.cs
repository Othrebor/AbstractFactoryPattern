namespace CoffeeWorld
{
    class CoffeeShop
    {
        private readonly ICoffeeFactory _coffeeFactory;
        public CoffeeShop(ICoffeeFactory coffeeFactory)
        {
            _coffeeFactory = coffeeFactory;
        }

        public CoffeeType Type { get; set; }
        public CoffeeFlavor Flavor { get; set; }

        public void GetOrder(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor, int size)
        {
            System.Console.WriteLine("Getting order from customer.");
            Type = coffeeType;
            Flavor = coffeeFlavor;
        }
        public void PrepareCoffee()
        {
            _coffeeFactory.CreateCoffee(Type, Flavor);
        }

        public void DeliverCoffee()
        {
            System.Console.WriteLine("Deliver coffee.");
        }
    }
}