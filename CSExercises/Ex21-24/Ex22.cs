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
           Random r = new Random();
            int guess,x;
            int secretnumber = r.Next(1, 11);

            do
            {
            Console.WriteLine("Enter your guess number");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess = secretnumber)
            {
                Console.WriteLine("You have got the number");
            }
            else
            {
                Console.WriteLine("Try again");
            } (while guess!= secretnumber);

            
        }
    }
}
