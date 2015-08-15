using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the temp in Centigrade");
            double c = Convert.ToDouble(Console.ReadLine());
            double f = 1.8 * c + 32;
            Console.WriteLine("The temp in F is {0}", f);

        }
    }
}
