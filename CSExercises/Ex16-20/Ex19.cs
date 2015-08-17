using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance travelled in KM");
            double distance = Convert.ToDouble(Console.ReadLine());
            
            double mc = 2.4;
            double totalcharge;

            if (distance >= 9)
            {
                distance = distance * 1000;
                distance = Math.Ceiling(distance / 100);
                totalcharge = mc + (85 * 0.04) + ((distance - 90) * 0.05);

            }

            else
            {
                distance = distance * 1000;
                distance = Math.Ceiling(distance / 100);
                totalcharge = mc + (distance - 5) * 0.04;
            }

            Console.WriteLine("The fare amount is ${0:0.000}", totalcharge);

        }
    }
}