using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator.Domain
{
    public class Calculator
    {
        private readonly ILogger _logger;
        private readonly Operations _operations;

        public Calculator(Operations operations, ILogger logger)
        {
            _operations = operations;
            _logger = logger;
        }

        public int Calculate(int firstNumber, int secondNumber, string operation)
        {
            Func<int, int, int> function = _operations.Get(operation);

            int result = function(firstNumber, secondNumber);

            _logger.Write("Calculate called " + firstNumber + " " + operation + " " + secondNumber + " Result = " + result);

            return result;
        }
    }
}
