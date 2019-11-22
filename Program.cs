using System;

namespace CoffeeWorld
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop starbucksCoffee = new CoffeeShop(new StarbucksCoffee());

            starbucksCoffee.GetOrder(CoffeeType.Hot, CoffeeFlavor.Cappuccino, 1);
            starbucksCoffee.PrepareCoffee();
            starbucksCoffee.DeliverCoffee();
            

            CoffeeShop cielitoLindoCafe = new CoffeeShop(new CielitoLindoCafe());

            cielitoLindoCafe.GetOrder(CoffeeType.Hot, CoffeeFlavor.Cappuccino, 2);
            cielitoLindoCafe.PrepareCoffee();
            cielitoLindoCafe.DeliverCoffee();
        }
    }
}
