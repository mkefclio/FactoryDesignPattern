// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern;

var factory = new IceCreamFactory();

var vanillaIceCream = factory.CreateIceCream("vanilla");

Console.WriteLine(vanillaIceCream.GetFlavor()); // Output: Vanilla Ice Cream

var chocolateIceCream = factory.CreateIceCream("chocolate");

Console.WriteLine(chocolateIceCream.GetFlavor()); // Output: Chocolate Ice Cream

var strawberryIceCream = factory.CreateIceCream("strawberry");

Console.WriteLine(strawberryIceCream.GetFlavor()); // Output: Strawberry Ice Cream