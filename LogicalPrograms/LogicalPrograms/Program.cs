﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("*________Logical Programs________*");
            Console.WriteLine("1. Fibonacci series");
            Console.Write("Enter: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Series();
                    break;
                default:Main();
                    break;
            }
        }
    }
}
