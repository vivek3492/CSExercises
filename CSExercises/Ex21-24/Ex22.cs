



using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B");
            int b = Convert.ToInt32(Console.ReadLine());
            int hcf, lcm, a1 = a, b1 = b, t;


            if (a > b)
            {
                while (a != b)
                {
                    t = (a - b);
                    a = t;
                }

                hcf = a;
                Console.WriteLine("HCF is {0}", hcf);
            }

            else
            {
                while (b != a)
                {


                    t = b - a;
                    b = t;

                }
                hcf = b;
                Console.WriteLine("HCF is {0}", hcf);
            }


            lcm = (a1*b1)/hcf;
            Console.WriteLine("LCM is {0}", lcm);
            Console.ReadLine();


        }
    }
}
