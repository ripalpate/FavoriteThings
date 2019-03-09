using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.AutoMobiles
{
    class Car : Automobile
    {
        public int Seaters { get; protected set; }
        //Constructors
        public Car(string model, string make, int seaters ) : base(model, make, 2015, CarColors.Grey )
        {
            Seaters = seaters;
        }

        //Methods
        public override void Ride()
        {
            base.Ride();
        }

        public void Noise()
        {
            Console.WriteLine("I am environment safe and barely make loud noises");
        }
    }
}
