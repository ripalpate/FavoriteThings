using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Pets
{
    class Cat : Pet
    {
        //Properties
        public string NailLength { get; set; }

        //constructors
        public Cat(string name, int age, int numberOfLegs, Colors color, string nailLength)
            : base(name, age, numberOfLegs, color)
        {
            NailLength = nailLength;
        }

        //method
        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("meow meow meow......");
        }

        public void Eat()
        {
            Console.WriteLine("Milk is my favorite");
        }
    }
}
