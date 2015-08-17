using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your marks");
            double marks = Convert.ToDouble(Console.ReadLine());
            if (marks>=80 && marks<=100)
            {
                Console.WriteLine("You have scored A grade");
            }
            else if (marks>=60 && marks<=79)
            {
                Console.WriteLine("You have scored B grade");

            }
            else if (marks >= 40 && marks <= 59)
            {
                Console.WriteLine("You have scored C grade");

            }
            else if (marks >= 0 && marks <= 40)
            {
                Console.WriteLine("You have scored F grade");

            }
            else
            {
                Console.WriteLine("Invalid marks");   
            }
            
            
        }
    }
}