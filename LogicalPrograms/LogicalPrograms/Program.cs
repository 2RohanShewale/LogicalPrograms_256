using System;
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
            Console.WriteLine("1. Fibonacci series\n2. Perfect Number\n3. Prime Numbers");
            Console.Write("Choose Option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.Series();
                    break;
                case 2:
                    PerfectNumber perfect = new PerfectNumber();
                    perfect.Number(); 
                    break;
                case 3:
                    PrimeNumber prime = new PrimeNumber();
                    prime.Number();
                    break;
                default:Main();
                    break;
            }
        }
    }
}
