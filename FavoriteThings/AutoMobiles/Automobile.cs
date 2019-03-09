using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
   abstract class Automobile
    {
        public string Make { get; protected set; }
        public string Model { get; protected set; }
        public int Year { get; protected set; }
        public CarColors CarColor { get; set; }

        const int MinYear = 1990;
        const int MaxYear = 2019;

        public Automobile(string make, string model, int year, CarColors carColor)
        {
            Make = make;
            Model = model;
            Year = year;
            CarColor = carColor;
        }

        public virtual void SetYear(int limitYear)
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

        public virtual void Ride()
        {
            Console.WriteLine("It's smooth ride.....!");
        }

        public virtual void Start(int limitYear)
        {
            if (limitYear >= MaxYear)
            {
                Console.WriteLine("This automobile can auto start if you have upgarded model");
            }
            else if (limitYear < 2014 && limitYear > MinYear)
            {
                Console.WriteLine("This automobile is  manual start");
            }
            else
            {
                throw new Exception($"Please use year between {MinYear} and {MaxYear}");
            }
        }

        public override string ToString()
        {
           return $"My favorite Automobile is {Year} {CarColor} {Make} {Model}.";
        }
    }

    enum CarColors
    {
        White,
        Black,
        Silver,
        Blue,
        Red,
        Grey,
        Gold
    }
}
