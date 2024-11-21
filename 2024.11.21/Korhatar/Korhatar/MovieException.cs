using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhatar
{
    internal class MovieException : Exception
    {
        public Movie Movie { get; }

        public MovieException(Movie movie)
        {
            Movie = movie;
        }
    }
}
