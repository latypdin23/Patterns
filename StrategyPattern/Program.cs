using StrategyPattern.Classes;
using StrategyPattern.Model;
using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cooker bob = new Cooker("Bob");
            bob.MakeDinner(new PotatoMeal()); //Метод MakeDinner может в качестве аргумента принять PotatoMeal и SaladMeal
            Console.WriteLine();
            bob.MakeDinner(new SaladMeal());
        }
    }
}
