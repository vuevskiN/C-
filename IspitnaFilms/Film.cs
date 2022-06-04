using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitnaFilms
{
    public class Film
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public List<Rating> ratings { get; set; }

        public Film(string name, int year)
        {
            Name = name;
            Year = year;
            ratings = new List<Rating>();
        }

        public Film()
        {

        }

        public override string ToString()
        {
            return string.Format("{0} ({1})",Name,Year);
        }

        public int  CountRatings()
        {
            return ratings.Count;
        }
    }
}
