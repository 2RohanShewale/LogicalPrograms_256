using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        bool isPrime = true;
        public void Number()
        {
            Console.WriteLine("\n*_____Prime Number_____*");
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 2)
            {
                for (int i = 2; i <= number/2; i++)
                {
                    if (number%i == 0)
                    {
                        isPrime= false;
                        break;
                    }
                        
                }
            }
            if (number ==1) { isPrime= false; }
            if (isPrime)
                Console.WriteLine($">>>> {number} is a prime number");
            else
                Console.WriteLine($">>>> {number} is not a prime number.");

        }
    }
}
