using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Foods
{
    class Mexican : Food
    {
        public SpiceLevels SpiceLevel { get; protected set; }
        //constructors
        public Mexican(string name, string appealing, int userRating, string review) :base(name, appealing, userRating, review)
        {
        }
        //methods
        public override void SetRating(int userRating)
        {
            base.SetRating(userRating);
        }

        public override void SetRating(int userRating, string review)
        {
            base.SetRating(userRating, review);
        }

        internal enum SpiceLevels
        {
            Mild,
            Medium,
            Hot,
            VeryHot
        }
    }
}
