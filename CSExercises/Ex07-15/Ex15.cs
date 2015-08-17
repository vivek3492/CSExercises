using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {

            int Arm, Hundred, Ten, One;
            bool flag = true;
            while (flag)
            { 
            Console.WriteLine("Enter the Armstrong number");
            Arm = Convert.ToInt32(Console.ReadLine());
            if (Arm >=100 && Arm <= 999)
            {
                Hundred = (Arm/100);
                Ten = (Arm-Hundred*100)/10;
                One = (Arm-Hundred*100-Ten*10);
                if ((Math.Pow(Hundred, 3)) + (Math.Pow(Ten, 3)) +(Math.Pow(One, 3))==Arm)

                {
                    Console.WriteLine("The number {0} is an Armstrong number", Arm);
                    flag = false;
                }
                else
                {
                    Console.WriteLine("The number {0} is not an Armstrong number", Arm);
                    flag = true;
                
                }
            }
          }

        }
    }
}
