using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int guess, x = 0;
            int secretnumber = r.Next(1, 11);

            do
            {
                Console.WriteLine("Enter your guess number");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == secretnumber)
                {
                    Console.WriteLine("You have got the number");
                    Console.WriteLine("It has taken {0} attempts to make the correct guess", x);
                }

                else
                {
                    Console.WriteLine("Try again");
                    x++;

                }
            }
            while (guess != secretnumber);

            if (x <= 2)
            {
                Console.WriteLine("You are a wizard");
            }
            else if (x >= 3 && x <= 5)
            {
                Console.WriteLine("You are a good guess");

            }

            else
            {

                Console.WriteLine("You are lousy");
            } 
        }
    }
}
