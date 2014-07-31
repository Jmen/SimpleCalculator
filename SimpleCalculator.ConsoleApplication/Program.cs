using SimpleCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int firstNumber = GetNumberInput();
            int secondNumber = GetNumberInput();

            string operation = GetOperatorInput();
            
            int result = calculator.Calculate(firstNumber, secondNumber, operation);
            
            Console.WriteLine("Result = " + result);
        }

        private static int GetNumberInput()
        {
            int result = 0;
            bool inputValid = false;

            while (!inputValid)
            {
                Console.WriteLine("Enter a number : ");
                string numberString = Console.ReadLine();

                inputValid = int.TryParse(numberString, out result);

                if (!inputValid)
                {
                    Console.WriteLine("Error : input not a valid number - Limit is " + int.MaxValue + " to " + int.MinValue);
                }
            }

            return result;
        }

        private static string GetOperatorInput()
        {
            string result = string.Empty;

            while (!ValidOperator(result))
            {
                Console.WriteLine("Enter an operator : ");
                result = Console.ReadLine();

                if (!ValidOperator(result))
                {
                    Console.WriteLine("Error : unknown operator");
                }
            }

            return result;
        }

        private static bool ValidOperator(string result)
        {
            return result == "+" || result == "-";
        }
    }
}
