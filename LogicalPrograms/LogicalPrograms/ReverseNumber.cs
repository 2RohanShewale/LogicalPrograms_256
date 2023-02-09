using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{

    public class ReverseNumber
    {
        public void Number()
        {
            Console.WriteLine($"\n*_____Reverse a Number_____*");
            Console.Write($"Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int reversedNumber = 0;
            while (number != 0)
            {
                int remainder = number % 10;
                Console.WriteLine(remainder);
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine($">>> Reversed Number: {reversedNumber}");

        }
    }
}
