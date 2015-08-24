using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            Console.WriteLine("Name\t Marks");
            for (int i = 0; i < marks.Length; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] < marks[j])
                    {
                        int temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;

                        string dummy = name[i];
                        name[i] = name[j];
                        name[j] = dummy;

                    }

                }

            }

            for (int i = 0; i < marks.Length; i++)
            {

                Console.WriteLine("{0}\t {1}", name[i], marks[i]);
            }

            Console.WriteLine("------------------------------");


            string[] name1 = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks1 = new int[] { 63, 29, 75, 82, 55 };

            Array.Sort(name1,marks1);
            for (int i = 0; i < marks1.Length; i++)
            { 
                Console.WriteLine("{0}\t {1}", name1[i], marks1[i]);
            }

            Console.ReadLine();

        }
    }
}
