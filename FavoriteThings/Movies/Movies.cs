using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings
{
    class Movies
    {
        public string Name { get; }
        public GenreType Type { get; }
        public int Rating { get; private set; }
        public string Review { get; private set; }

        public Movies(string name, GenreType type)
        {
            Name = name;
            Type = type;
        }

        const int MinRatingValue = 1;
        const int MaxRatingValue = 10;

        public void SetRating(int userRating)
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
        public void SetRating(int userRating, string review)
        {
            SetRating(userRating);
            Review = review;
        }
    }
    enum GenreType
    {
        Comedy,
        Drama,
        Romantic,
        Horror,
        Documentry,
        Thriller,
        Action,
        Animation
    }
}

