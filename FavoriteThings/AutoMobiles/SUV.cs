using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.AutoMobiles
{
    class SUV : Automobile
    {
        public SUV(string model, string make, int year) : base(model, make, year, CarColors.Black)
        {
        }

        public override void SetYear(int limitYear)
        {
            base.SetYear(limitYear);
        }

        public override void Ride()
        {
            Console.WriteLine("Its Laxurious ride");
        }
    }
}
