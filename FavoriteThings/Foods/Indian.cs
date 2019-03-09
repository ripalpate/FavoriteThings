using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Foods
{
    class Indian : Food
    {
        //preperties
        public string SpiceLevel { get; protected set; }
       

        //constructors
        public Indian(string name, string appealing, string spiceLevel, int userRating, string review) : base(name, appealing, userRating, review)
        {
            SpiceLevel = spiceLevel;
        }

        //Methods
        public override void SetRating(int userRating)
        {
            base.SetRating(userRating);
        }

        public override void SetRating(int userRating, string review)
        {
            base.SetRating(userRating, review);
        }

        public override string ToString()
        {
            return $"My favorite food is {Name} and its very {Appealing} and {SpiceLevel} spicy. Also it is rated {Rating} with review of {Review}";
        }
    }
}
