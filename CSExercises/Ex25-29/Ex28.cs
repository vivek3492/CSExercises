using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
          int k = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    k++;

                }

            }

                if (k == 2)
                {
                    Console.WriteLine("The number is a Prime number");
                }
                else
                {
                    Console.WriteLine("The number is not a Prime number");
                }
                Console.ReadLine();


        }
    }
}
