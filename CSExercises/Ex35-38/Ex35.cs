using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {


            int i, total;
            Console.WriteLine("Enter the phrase");
            string phrase = Console.ReadLine();
            int A = 0, E = 0, I = 0, O = 0, U = 0;
            string up;
            up = phrase.ToUpper();


            for (i = 0; i < phrase.Length; i++)
            {
                if (up[i] == 'A')
                    A++;
                else if (up[i] == 'E')
                    E++;
                else if (up[i] == 'O')
                    O++;
                else if (up[i] == 'U')
                    U++;
                else if (up[i] == 'I')
                    I++;

            }
            total = A + E + I + O + U;
            Console.WriteLine("Total no of vowels are {0}", total);
            Console.WriteLine("Number of a is {0}", A);
            Console.WriteLine("Number of e is {0}", E);
            Console.WriteLine("Number of i is {0}", I);
            Console.WriteLine("Number of o is {0}", O);
            Console.WriteLine("Number of u is {0}", U);


         }
    }
}
