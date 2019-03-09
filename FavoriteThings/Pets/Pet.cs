using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
   abstract class Pet
    {
        //Properties
        public string Name { get; protected set; }
        public int Age { get; protected set; }
        public int NumberOfLegs { get; protected set; }
        public Colors Color { get; protected set; }

        //Constructors
        protected Pet (string name, int age, int numberOfLegs, Colors color)
        {
            Name = name;
            Age = age;
            NumberOfLegs = numberOfLegs;
            Color = color;
        }

        //Methods
        public virtual void Talk()
        {
            Console.WriteLine( "feed me...!");
        }

        public string Lick()
        {
            return "Tastes like human";
        }

        public override string ToString()
        {
            return $" My favorite pet is {Name} who is {Age} years old and has {NumberOfLegs} legs";
        }
    }
}
