using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {

            Console.WriteLine("Enter the strings");
            string x = Console.ReadLine().ToLower();
            string y = Console.ReadLine().ToLower();

            Console.WriteLine(Convert.ToBoolean(InString(x, y)));

        }
        public static bool InString(string s1, string s2)
        {
            s1.ToLower();
            s2.ToLower();
            if (!s1.Contains(s2))
                return false;
            else
                return true;
        }
    }
}
