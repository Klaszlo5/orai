using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korhatar
{
    internal class Movie
    {
        private int[] rates;
        private int rates_n;

        public string Title { get; }
		public int Price { get; }

        public Movie(string title, int price) {
            Title = title;
            Price = price;

            rates = new int[10];
            rates_n = 0;
        }


        public void Rating(int value)
        {
            if (value < 1 || value > 5)
            {
                throw new ArgumentException("Az értékelésnek 1 és 5 közötti egész számnak kell lennie!");
            }

            if (rates_n >= 10) {
                throw new NewRateException(this, value);
            }

            rates[rates_n] = value;
            rates_n = rates_n + 1;
        }

   
        public double Average
        {
            get
            {
                if (rates_n == 0) {
                    throw new AverageCalculationException(this);
                }

                int sum = 0;
                for (int i = 0; i < rates_n; i++)
                {
                    sum = sum + rates[i];
                }

                return (double)sum / rates_n;
            }
        }

    }
}
