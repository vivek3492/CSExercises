using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Perfect Numbers between 1 and 1000 are : ");


            for (int j=1;j<1000;j++)
            {
                int sum = 0;

                for (int i=1;i<j;i++)
                {
                    if (j%i==0)
                    {
                        sum = sum + i;

                    }
                }
                    if (sum==j)
                    {
                        Console.WriteLine(j);
                    }
                    
                    
               }



        }
    }
}
