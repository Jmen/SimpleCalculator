using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator.Domain
{
    public class Calculator
    {
        private ILogger _logger;

        public Calculator(ILogger logger)
        {
            _logger = logger;
        }

        public int Calculate(int firstNumber, int secondNumber, string operation)
        {
            int result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                default:
                    throw new Exception("Unknown operator");
            }

            _logger.Write("Calculate called " + firstNumber + " " + operation + " " + secondNumber + "Result = " + result);

            return result;
        }
    }
}
