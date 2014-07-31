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

            Console.WriteLine("Enter a number : ");
            string firstNumberString = Console.ReadLine();

            int firstNumber;

            if(int.TryParse(firstNumberString, out firstNumber))
            {
                Console.WriteLine("Enter a number : ");
                string secondNumberString = Console.ReadLine();

                Console.WriteLine("Enter an operator : ");
                string operation = Console.ReadLine();

            
                int secondNumber = int.Parse(secondNumberString);

                int result = calculator.Calculate(firstNumber, secondNumber, operation);
        
                Console.WriteLine("Result = " + result);
            }
            else
            {
                Console.WriteLine("Error : input not a valid number - Limit is " + int.MaxValue + " to " + int.MinValue);
            }
        }
    }
}
