using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Pets
{
    class Rabbit: Pet
    {
        public string FavoriteFood { get; set; }

        public Rabbit(string name, int age, int numberOfLegs, string favoriteFood)
            : base(name, age, numberOfLegs, Colors.White)
        {
            FavoriteFood = favoriteFood;
        }

        public override void Talk()
        {
            Console.WriteLine("bleat bleat....");
        }

        public void Jump()
        {
            Console.WriteLine(" Kelly jumps hop hop...");
        }
    }
}
