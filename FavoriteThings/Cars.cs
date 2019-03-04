using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Cars
    {
        public string Make { get; }
        public string Model { get; }
        public int Year { get; private set; }
        public string Condition { get; }
        public CarType Type { get; }

        const int MinYear = 1990;
        const int MaxYear = 2019;

        public Cars(string make, string model, string condition, CarType type)
        {
            Make = make;
            Model = model;
            Condition = condition;
            Type = type;
        }

        public void SetYear(int limitYear)
        {
            if (limitYear >= MinYear && limitYear <= MaxYear)
            {
                Year = limitYear;
            }
            else
            {
                throw new Exception($"Please use year between {MinYear} and {MaxYear}");
            }
        }
    }

    enum CarType
    {
        Convertible,
        Sedan,
        Coupe,
        Sport,
        SUV,
        Truck,
        CrossOver
    }
}
