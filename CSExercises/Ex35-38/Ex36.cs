using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter String:");
            string input = Console.ReadLine();
            string up = input.ToUpper();


            string r = "";
            for (int i = input.Length-1; i >=0; i--)
            {
               r = r + input[i].ToString();
            }
            
            if (input == r)
    
            {
                Console.WriteLine("Palindrome");
            }

            else
            {
                Console.WriteLine("Not Palindrome");
            }



         }
    }
}
