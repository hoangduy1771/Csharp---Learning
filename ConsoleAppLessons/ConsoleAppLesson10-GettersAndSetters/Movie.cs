using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLesson10_GettersAndSetters
{
    class Movie
    {
        private string title;
        private string director;
        private string rating;

        public Movie(string mTilte, string mDirector, string mRating)
        {
            title = mTilte;
            director = mDirector;
            Rating = mRating;
        }

        // property : define getters and setters
        public string Rating
        {
            get { return rating; }
            set 
            { 
                // set the value to be certain value
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
