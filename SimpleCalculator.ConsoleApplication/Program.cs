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

            Console.WriteLine("Enter a number : ");
            string secondNumberString = Console.ReadLine();

            Console.WriteLine("Enter an operator : ");
            string operation = Console.ReadLine();

            int firstNumber = int.Parse(firstNumberString);
            int secondNumber = int.Parse(secondNumberString);

            int result = calculator.Calculate(firstNumber, secondNumber, operation);

            Console.WriteLine("Result = " + result);
        }
    }
}
