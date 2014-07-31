using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator.Domain
{
    public class OperationsList : Dictionary<string, Func<int, int, int>> { }

    public class Calculator
    {
        private ILogger _logger;
        private OperationsList _operations;

        public Calculator(OperationsList operations, ILogger logger)
        {
            _operations = operations;
            _logger = logger;
        }

        public int Calculate(int firstNumber, int secondNumber, string operation)
        {
            int result = 0;

            Func<int, int, int> function = _operations[operation];
           
            result = function(firstNumber, secondNumber);

            _logger.Write("Calculate called " + firstNumber + " " + operation + " " + secondNumber + " Result = " + result);

            return result;
        }
    }
}
