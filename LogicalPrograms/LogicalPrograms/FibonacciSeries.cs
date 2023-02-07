using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        int firstNumber = 0;
        int secondNumber = 1;
        int fibonacciNumber ;
        public void Series()
        {
            Console.WriteLine("*_____Fibonacci Series_____*");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.Write($">>>{number}th Fibonacci number is ");
            if (number == 0)
                Console.Write(0);
            else if (number == 1)
                Console.WriteLine(1);
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    fibonacciNumber = secondNumber + firstNumber;
                    firstNumber = secondNumber;
                    secondNumber = fibonacciNumber;
                }
                Console.WriteLine(fibonacciNumber);
            }
            Program.Main();
        }
    }
}
