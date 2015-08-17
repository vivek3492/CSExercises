using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Quantity for TV");
            double tv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity for DVD");
            double  dvd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Quantity for MP3");
            double mp = Convert.ToInt32(Console.ReadLine());

            double tvp = 900, dvdp = 500, mpp = 700, total;

            total = (tv * tvp) + (dvd * dvdp) + (mp * mpp);

            if (total > 5000)
            {
                tvp = ((tv * tvp)-((tv * tvp) * 0.10));
                dvdp = ((dvd * dvdp)-((dvd * dvdp) * 0.10));
                mpp = mp * mpp;
                total = tvp+dvdp+mpp;
                Console.WriteLine("The total cost of the products is ${0}", total);
            }
            else if (total > 10000)
            {
                tvp = ((tv * tvp) - ((tv * tvp) * 0.15));
                dvdp = ((dvd * dvdp) - ((dvd * dvdp) * 0.15));
                mpp = mp * mpp;
                total = tvp+dvdp+mpp;
                
                Console.WriteLine("The total cost of the products is ${0}", total);
            }
            else
            {
                Console.WriteLine("The total cost of the products is ${0}", total);
            }
        }
    }
}