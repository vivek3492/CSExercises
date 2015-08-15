using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of 3 sides");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double s = ((a + b + c) / 2);
            double area = ((s*(s - a))*(s - b)*(s - c));
            Console.WriteLine("The area of the triangle is {0}", Math.Sqrt(area));

        }
    }
}
