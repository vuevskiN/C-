using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IspitnaFilms
{
    public class Rating
    {
        public decimal rating { get; set; }

        public Rating(decimal rating)
        {
            this.rating = rating;
        }

        public Rating()
        {

        }

        public override string ToString()
        {
            return String.Format("{0}",rating);
        }

        
    }
}
