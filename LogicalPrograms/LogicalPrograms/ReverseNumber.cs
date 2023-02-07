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
            string numberInString = Console.ReadLine();
            int number = Convert.ToInt32(numberInString);

            int reversedNumber = 0;
            for (int i = 0; i < numberInString.Length; i++)
            { 
                int remainder = number%10;
                Console.WriteLine(remainder);
                reversedNumber = reversedNumber * 10 + remainder;
                number /= 10;
            }

            Console.WriteLine($">>> Reversed Number: {reversedNumber}");

        }
    }
}
