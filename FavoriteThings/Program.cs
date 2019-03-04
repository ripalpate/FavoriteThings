using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var camry = new Cars("Toyota", "Camry", "new", CarType.Convertible);
            camry.SetYear(2018);

            var dog = new Pets("Tommy", 3, PetType.Dog);

            var kachoriChat = new Foods("kachori Chat", CuisineType.Indian);
            kachoriChat.SetRating(8);
            kachoriChat.SetRating(8, "It's delicious");

            var minion = new Movies("Despicable Me", GenreType.Animation);
            minion.SetRating(9);
            minion.SetRating(9, "loved it");

            Console.WriteLine($"{dog.Name} is {dog.Age} years old {dog.Type}.");
            Console.WriteLine($"I like {camry.Type} {camry.Make} {camry.Model} in {camry.Condition} condition!");
            Console.WriteLine($"{kachoriChat.Name} is {kachoriChat.Type} dish and it's rated {kachoriChat.Rating} with review of {kachoriChat.Review}. ");
            Console.WriteLine($"{minion.Name} is {minion.Type} movie and it's rated {minion.Rating} with review of {minion.Review}.");
            Console.ReadLine();
        }
    }
}
