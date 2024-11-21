using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhatar
{
    internal class AverageCalculationException : MovieException
    {
        public AverageCalculationException(Movie movie) : base (movie) {}

        public override string Message => 
            $"Nincs értékelés az átlag kiszámításához! Film:{Movie.Title}";
    }
}
