using System;
using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace Deliverable_2

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Welcome Schitty Wok Buffet. All you can eat for $9.99! We only charge extra for coffee. How many people are in your group? Please, parties of 6 or lower.");

            var partySize = Console.ReadLine();
            int partySizeInt = Int16.Parse(partySize);

            if (partySizeInt > 6)
            {
                Console.WriteLine("Oh Sorry we can only seat parties of 6 or less at this time, please try the place next door");
            }
            else
            {
                Console.WriteLine($"A table for {partySize} right this way we have a nice table by the window");
                Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");

                int coffeeCount = 0;
                int waterCount = 0;
                int buffetCount = 0;
                double coffeePrice = 2.00;
                double waterPrice = 0.00;
                double buffetPrice = 9.99;

                for (int i = 1; i <= partySizeInt; i++)

                {
                    Console.WriteLine($"Alright, person number {i}, water or coffee?");
                    var drinkOrder = Console.ReadLine();

                    if (drinkOrder == "coffee")
                    {
                        coffeeCount += 1;
                        buffetCount += 1;
                    }

                    else if (drinkOrder == "water")
                    {
                        waterCount += 1;
                        buffetCount += 1;
                    }
                    else
                    {
                        buffetCount += 1;
                        Console.WriteLine("We don't offer that drink but I'll give you the buffet order.");
                    }
                }

                Console.WriteLine($"Okay so that's {coffeeCount} coffees and {waterCount} waters. I'll be right back. Feel free to fill your bellies!");

                double totalCoffeePrice = coffeeCount * coffeePrice;
                double totalBuffetPrice = buffetCount * buffetPrice;
                double totalPrice = totalBuffetPrice + totalCoffeePrice;

                Console.WriteLine($"{buffetCount} buffets = {buffetCount} x {buffetPrice} = {totalBuffetPrice}");
                Console.WriteLine($"{coffeeCount} Coffees = {coffeeCount} x {coffeePrice} = {totalCoffeePrice}");
                Console.WriteLine($"{waterCount} waters = free");
                Console.WriteLine($"total = {totalPrice}");
            }
        }
    }
}