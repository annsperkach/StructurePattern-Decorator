using PizzaMaker.Decorators;
using PizzaMaker.Models;
using System;

namespace PizzaMaker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DefaultPizza dp = new DefaultPizza();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Let's order the pizza:");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Amount of the components:");
            Console.ResetColor();
            Console.WriteLine(dp.GetAmountOfComponent());
            var beckonCheesePizza = new BeckonPizzaDecorator(new CheesePizzaDecorator(new DefaultPizza()));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Add some cheese and beckon:");
            Console.ResetColor();
            Console.WriteLine(beckonCheesePizza.GetAmountOfComponent());
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The cost of the pizza:");
            Console.ResetColor();
            Console.WriteLine(beckonCheesePizza.GetCost());

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Let's order the pizza:");
            Console.ResetColor();
            var beckonCheesePeperoniPizza = new BeckonPizzaDecorator(new CheesePizzaDecorator(new PeperoniPizzaDecorator(new DefaultPizza())));
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Amount of the components:");
            Console.ResetColor();
            Console.WriteLine(beckonCheesePeperoniPizza.GetAmountOfComponent());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The cost of the pizza:");
            Console.ResetColor();
            Console.WriteLine(beckonCheesePeperoniPizza.GetCost());
        }
    }
}
