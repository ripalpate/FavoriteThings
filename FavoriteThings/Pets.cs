using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Pets
    {
        public string Name { get; }
        public int Age { get; }
        public PetType Type { get; }

        public Pets(string name, int age, PetType type)
        {
            Name = name;
            Age = age;
            Type = type;

        }
    }

    enum PetType
    {
        Dog,
        Cat,
        Bird,
        Hedgehog,
        Turtle,
        Rabbit
    }
}
