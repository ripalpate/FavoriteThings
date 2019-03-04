using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var camry = new Cars("Toyota", "Camry", "new", CarType.Convertible);
            camry.SetYear(2018);
            Console.WriteLine("What is your Favorite Car?");
            Console.WriteLine($"I like {camry.Type} {camry.Make} {camry.Model} in {camry.Condition} condition!");
            Console.ReadLine();
        }
    }
}
