using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\t Y");
            Console.WriteLine("--------------------------------------------");
            double t;
            for (double x = -5; x <= 5; x++)
            {
                double y = ((2 * (x * x)) - (4 * x) + 3);
                Console.WriteLine("{0}\t {1:0.000}", x, y);
                t = y;

                for (int j =0; j<y;j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine("{0} times total printed", t);
                  
            }
            
            Console.ReadLine();

            
        }
    }
}
