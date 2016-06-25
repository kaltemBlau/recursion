using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString;
            int n;
            Console.WriteLine("Calculate a factorial by entering an integer greater than or equal to zero:");
            inputString = Console.ReadLine();
            while (!Int32.TryParse(inputString, out n) || n < 0)
            {
                Console.WriteLine("You did not enter a valid number.\nPlease enter an integer greater than or equal to zero:");
                inputString = Console.ReadLine();
            }
            FactorialCalculator newCalculator = new FactorialCalculator();
            int result = newCalculator.calculateFactorial(n);
            Console.WriteLine("The factorial of {0} is {1}", n, result);
            Console.ReadLine();
        }
    }
    class FactorialCalculator
    {
        public int calculateFactorial(int n)
        {
            if (n < 0)
            {
                // May want to raise error.
                return -1;
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * calculateFactorial(n - 1);
            }
        }
    }
}
