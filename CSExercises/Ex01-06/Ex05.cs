﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The squareroot of the number is {0:0.000}", Math.Sqrt(x));

        }
    }
}
