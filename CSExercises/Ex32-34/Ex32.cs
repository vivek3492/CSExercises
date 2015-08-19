using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            string [] month = new string[] { "Jan", "Feb", "Mar", "Apr", "MAy", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            int [] sales = new int[12];

            for (int i = 0; i < month.Length; i++)
            {
                Console.WriteLine("Enter the sales for the month {0}", month[i]);
                sales[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Sales for the {0}month is {1}", i, sales[i]);

            }
                Console.WriteLine("Maximum Sales: {0}", sales.Max());
                Console.WriteLine("Minimum Sales: {0}", sales.Min());
                Console.WriteLine("Average Sales: {0}", sales.Average());
                        
              Console.ReadLine();
                                   
        }
    }
}
