using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    abstract class Food
    {
        public string Name { get; protected set; }
        public string Appealing { get;  protected set; }
        public int Rating { get; protected set; }
        public string Review { get; protected set; }

        public Food(string name, string appealing, int userRating, string review)
        {
            Name = name;
            Appealing= appealing;
            Rating = userRating;
            Review = review;
        }

        //fields
        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        //Methods
        public virtual void SetRating(int userRating)
        {
            if (userRating >= MinRatingValue && userRating <= MaxRatingValue)
            {
                Rating = userRating;
            }
            else
            {
                throw new Exception($"Please use rating between {MinRatingValue}-{MaxRatingValue}");
            }

        }
        public virtual void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }

        //public override string ToString()
        //{
        //    return $"My favorite food is {Name} and its very {Appealing} is rated {Rating} with review of {Review}";
        //}

    }
}
