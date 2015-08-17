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
            int marks = Convert.ToInt32(Console.ReadLine());
            switch (marks)
            {
                case 1: 
                if (marks>=80 && marks<100 )
                    Console.WriteLine("You have got A Grade");
                    break;

                     case 2: 
                if (marks>=60&&marks<80 )
                    Console.WriteLine("You have got B Grade");
                    break; 
            }
        }
    }
}