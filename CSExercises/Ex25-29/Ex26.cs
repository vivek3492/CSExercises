using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("No:\tInverse:\tSquareRoot:\tSquare:\t ");
            Console.WriteLine("----------------------------------------------");
            double i, inverse, sqrt, sqr;
            for ( i = 1; i <= 10; i++)


            {

                inverse = (1 / i);
                sqrt = Math.Sqrt(i);
                sqr = i * i;

                Console.WriteLine("{0}\t {1:0.00}\t\t {2:0.000}\t\t {3:0.00}", i, inverse, sqrt, sqr);

                
                 }



        }
    }
}
