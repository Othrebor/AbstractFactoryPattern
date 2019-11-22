namespace CoffeeWorld
{
    public abstract class Coffee : ICoffee
    {
        public CoffeeFlavor Flavor { get; set; }
        public CoffeeType Type { get; set; }
        public Coffee(CoffeeType coffeeType, CoffeeFlavor coffeeFlavor)
        {
            Type = coffeeType;
            Flavor = coffeeFlavor;
        }
        public int Size { get; set; }
        public double Price { get; set; }
        public abstract void PrepareCoffee();
    }
}