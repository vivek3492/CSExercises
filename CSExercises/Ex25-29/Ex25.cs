using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
        
            ////25a
            //Console.WriteLine("Enter the number");
            //int num  = int.Parse(Console.ReadLine());
            //int fact = 1; 

            //for (int i=1;i <=num; i++)
            //{
            //   fact = fact*i;

            //}
            //Console.WriteLine("Factorial of {0} is {1}", num, fact);
            //Console.ReadLine();





            Console.WriteLine("Enter the number");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;

            for (int i = num; i >= 1; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial of {0} is {1}", num, fact);
            Console.ReadLine();

                        
        }
    }
}
