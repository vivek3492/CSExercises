using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Prime Numbers :");
           

            for (int j=5;j<10000;j++)

            {
                int k = 0;  


                for (int i=1;i<=j;i++)


                {
                    if (j%i==0)

                    {
                        k++;

                    }
                }
                    if (k==2)

                    {

                        Console.WriteLine(j);
                    }
                   
          }
            Console.ReadLine();
  

        }
    }
}
