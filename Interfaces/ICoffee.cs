namespace CoffeeWorld
{
    public interface ICoffee
    {
        CoffeeFlavor Flavor { get; set; }
        CoffeeType Type { get; set; }
        int Size { get; set; }
        double Price { get; set; }
        void PrepareCoffee();
    }
}