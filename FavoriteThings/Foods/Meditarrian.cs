using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Foods
{
    class Meditarrian : Food
    {
        public Meditarrian(string name, string appealing, int userRating, string review) : base(name, appealing, userRating, review)
        {
        }

        public override void SetRating(int userRating)
        {
            base.SetRating(userRating);
        }

        public override void SetRating(int userRating, string review)
        {
            base.SetRating(userRating, review);
        }
    }
}
