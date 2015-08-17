using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter whether Male or Female");
            string gender = Console.ReadLine();
        
           if (gender == "Male") 
           {
               Console.WriteLine("Good Morning Mr.{0}", name);
           }
           else if  (gender == "Female")

           {
               Console.WriteLine ("Good Morning Ms.{0}", name);
           } 
        }
    }
}