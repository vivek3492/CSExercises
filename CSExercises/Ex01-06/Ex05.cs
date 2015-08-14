using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to get the square");
            int x = int.Parse(Console.ReadLine());
            int y = x * x;
            Console.WriteLine("Sqaure is {0} ", y);
        }
    }
}
