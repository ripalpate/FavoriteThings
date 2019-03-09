using FavoriteThings.AutoMobiles;
using FavoriteThings.Foods;
using FavoriteThings.Pets;
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFavoritePet = new Rabbit("Kelly", 2, 4, "Carrots");
            myFavoritePet.Jump();

            Console.WriteLine(myFavoritePet);


            var myfavoriteFood = new Indian("Paneer Tikka", "appealing", "medium", 8, "you should try it as it's very delicious");
            Console.WriteLine(myfavoriteFood);

            var myFavoriteCar = new SUV("Toyota", "Rav4", 2016);

            Console.WriteLine(myFavoriteCar);
            //var camry = new Cars("Toyota", "Camry", "new", CarType.Convertible);
            //camry.SetYear(2018);
            //camry.Ride();

            //var dog = new Pets("Tommy", 3, PetType.Dog);
            //dog.Lick();
            //dog.Talk();

            //var kachoriChat = new Foods("kachori Chat", CuisineType.Indian);
            //kachoriChat.SetRating(8);
            //kachoriChat.SetRating(8, "It's delicious");

            //var minion = new Movies("Despicable Me", GenreType.Animation);
            //minion.SetRating(9);
            //minion.SetRating(9, "loved it");

            //Console.WriteLine($"{dog.Name} is {dog.Age} years old {dog.Type} and {dog.Talk()} and my lick {dog.Lick()}.");
            //Console.WriteLine($"I like {camry.Type} {camry.Make} {camry.Model} in {camry.Condition} condition! {camry.Ride()}");
            //Console.WriteLine($"{kachoriChat.Name} is {kachoriChat.Type} dish and it's rated {kachoriChat.Rating} with review of {kachoriChat.Review}. ");
            //Console.WriteLine($"{minion.Name} is {minion.Type} movie and it's rated {minion.Rating} with review of {minion.Review}.");

            Console.ReadLine();
        }
    }
}
