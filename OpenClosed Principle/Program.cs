using OpenClosed_Principle.Core;
using OpenClosed_Principle.Infrastructure;

internal class Program
{
    private static void Main(string[] args)
    {

        MealBase[] menu = new MealBase[] { new PotatoMeal(), new SaladMeal() };

        Cook bob = new Cook("Bob");
        bob.MakeDinner(menu);


        Console.WriteLine("Hello, World!");
    }
}