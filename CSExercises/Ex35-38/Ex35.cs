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

            Console.WriteLine("Please enter a phrase");
            string phrase = Console.ReadLine();
            int a = 0, e = 0, i = 0, o = 0, u = 0;
            for (int j = 0; j < phrase.Length; j++)
            {
                if (phrase[j] == 'a') a++;
                if (phrase[j] == 'e') e++;
                if (phrase[j] == 'i') i++;
                if (phrase[j] == 'o') o++;
                if (phrase[j] == 'u') u++;
            }
            int count = a + e + i + o + u;
            Console.WriteLine("The total number of vowels is" + count);
            Console.WriteLine("The number of a is" + a);
            Console.WriteLine("The number of e is" + e);
            Console.WriteLine("The number of i is" + i);
            Console.WriteLine("The number of o is" + o);
            Console.WriteLine("The number of u is" + u);
            

         }
    }
}
