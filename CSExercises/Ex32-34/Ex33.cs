using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] no = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };

            for (int i=0;i<no.Length;i++)
            {

                for(int j=i+1;j<no.Length;j++)
                {

                    if(no[i]<no[j])
                    {
                        int temp = no[i];
                        no[i] = no[j];
                        no[j] = temp;
                     }
                }

            }

            for(int i=0;i<no.Length;i++)
            {

                Console.WriteLine("{0}\n", no[i]);
            }

            Console.ReadLine();
            
        }
    }
}
