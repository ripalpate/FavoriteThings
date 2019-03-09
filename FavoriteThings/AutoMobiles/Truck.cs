
using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.AutoMobiles
{
    class Truck : Automobile
    {
        public TruckTypes TruckType { get; set; }
        //Constructors
        public Truck(string make, string model, CarColors carColor, TruckTypes truckType) : base(make, model, 2000, carColor)
        {
            TruckType = truckType;
        }

        //Methods
        public override void Start(int limitYear)
        {
            base.Start(limitYear);
        }

        public void CanHaveBumpyRide()
        {
            Console.WriteLine("Sorry, you can't have bumpyride with this truck");
        }

        internal enum TruckTypes
        {
            SmallTruck,
            LightTruck,
            MediumTruck,
            HeavyTruck
        }
    }
}
