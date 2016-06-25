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
            FactorialCalculator newCalculator = new FactorialCalculator(isVerbose: true);
        }
    }
    class FactorialCalculator
    {
        string calculatorName = "Factorial Calculator";
        int inputInt;
        int factorial;
        public FactorialCalculator(bool isVerbose = false)
        {
            /*
             * Displays the title of the calculator.
             * Asks the user for a integer (repeating until a valid one is supplied).
             * Calculates the factorial (n!) of the integer.
             * Then presents the output.
             * Has an optional "verbose" flag for the text displayed.
             */
            DisplayTitle();
            inputInt = getInputInt(isVerbose);
            factorial = calculateFactorial(inputInt);
            displayResult(n: inputInt, result: factorial, verboseOutput: isVerbose);
        }
        public FactorialCalculator(int n)
        {
            factorial = calculateFactorial(n);
        }
        private int calculateFactorial(int n)
        {
            //Checking for invalid values of n.
            if (n < 0)
                // May want to directly raise error.
                return -1;
            if (n == 0 || n == 1)
                return 1;
            else
                return n * calculateFactorial(n - 1);
        }
        private void DisplayTitle()
        {
            char emphasisCharacter = '-';
            string emphasisLine = "";
            //Constructing emphasis line to be as long as calculatorName.
            for (int i = 0; i < calculatorName.Length; i++)
            {
                emphasisLine += emphasisCharacter;
            }
            //Printing the title to the console.
            Console.WriteLine(emphasisLine);
            Console.WriteLine(calculatorName);
            Console.WriteLine(emphasisLine);
        }
        private int getInputInt(bool verbose = false)
        {
            string rawInput;
            int inputInt;
            if (verbose)
                Console.WriteLine("Calculate a factorial by entering an integer greater than or equal to zero:");
            else
                Console.WriteLine("Enter an integer >=0:");
            rawInput = Console.ReadLine();
            while (!Int32.TryParse(rawInput, out inputInt) || inputInt < 0)
            {
                if (verbose)
                    Console.WriteLine("You did not enter a valid number.\nPlease enter an integer greater than or equal to zero:");
                else
                    Console.WriteLine("Invalid input integer. Reenter:");
                rawInput = Console.ReadLine();
            }
            return inputInt;
        }
        private void displayResult(int n, int result, bool verboseOutput = false)
        {
            if (verboseOutput)
                Console.WriteLine("The factorial of {0} is {1}.", n, result);
            else
                Console.WriteLine("{0}! = {1}.", n, result);
            Console.ReadLine();
        }
    }
}
