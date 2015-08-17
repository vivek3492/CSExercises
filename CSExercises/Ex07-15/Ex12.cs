using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance travelled in km");
            double d = Convert.ToDouble(Console.ReadLine());
            double fc = 2.40;
            double fare = fc + (0.4 * d);
            double r = Math.Round(fare, 2, MidpointRounding.AwayFromZero);
            
            Console.WriteLine("The total fare is ${0}", r);
          
        }
    }
}
