using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Pets

{
    class Dog : Pet
    {
        public Breeds Breed { get; protected set; }
        public Temperaments Temperament { get; set; }

        public Dog(string name, int age, int numberOfLegs, Colors color, Breeds Breed, Temperaments Temperament)
            : base(name, age, numberOfLegs, color)
        {
        }

        public override void Talk()
        { 
            Console.WriteLine("woof woof woof..........");
        }

    }

    internal enum Breeds
    {
        BullDog,
        Chihuahua,
        Pug,
        Samoyed,
        Havanese,
        AlaskanMalamute,
        GermanShephard,
        Rottweiler
    }

    internal enum Temperaments
    {
        Playful,
        Quite,
        Attentive, 
        Friendly,
        Stuborn,
        Charming
    }
}
