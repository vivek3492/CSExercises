using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
    namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("CHECKING PERFECT NUMBER");
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            

            for (int i =1; i<num;i++)
            {
                if(num%i==0)
                {
                    sum = sum + i;
                }

            }
        
        if(num==sum)
        {
            Console.WriteLine("It is a perfect number");
        }
        else
        {

            Console.WriteLine("It is not a perfect number");
        }

        }
                
    }
}
