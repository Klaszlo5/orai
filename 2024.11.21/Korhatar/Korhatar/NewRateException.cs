using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Korhatar
{
    internal class NewRateException : MovieException
    {
        public int Rate { get; }

        public NewRateException(Movie movie, int rate) : base(movie)
        {
            Rate = rate;
        }

        public override string Message { 
            get { 
                return $"Nem lehet több mint 10 értékelés! Sikertelen értékelés: {Rate}"; 
            }   
        }


    }
}
