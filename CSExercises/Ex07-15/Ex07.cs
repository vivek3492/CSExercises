using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            double ha, ta, total;
            ha = 0.1 * salary;
            ta = 0.03 * salary;
            total = salary + ha + ta;
            Console.WriteLine("Your nett salary is ${0}", total);

        }
    }
}
