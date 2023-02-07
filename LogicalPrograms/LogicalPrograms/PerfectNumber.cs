using System;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        int sum = 0;
        public void Number()
        {
            Console.WriteLine("\n*_____Perfect Number_____*");
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                    sum += i;
            }
            if (sum == number)
                Console.WriteLine($">>>>{number} is perfect number");
            else
                Console.WriteLine($">>>>{number} is not perfect number");
        }
    }
}
