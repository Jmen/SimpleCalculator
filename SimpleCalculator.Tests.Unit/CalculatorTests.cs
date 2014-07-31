using NUnit.Framework;
using SimpleCalculator.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests.Unit
{
    [TestFixture]
    public class CalculatorTests
    {
        MockLogger _logger;
        Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            Func<int, int, int> addition = (x, y) =>  x + y ;
            Func<int, int, int> subtraction = (x, y) => x - y;

            OperationsList operations = new OperationsList();

            operations.Add("+", addition);
            operations.Add("-", subtraction);

             _logger = new MockLogger();
             _calculator = new Calculator(operations, _logger);
        }

        [TestCase(1, "+", 1, 2)]
        [TestCase(1, "+", 2, 3)]
        public void Calculate_WhenTwoNumbersAdded_ResultIsAddition(int firstNumber, string operation, int secondNumber, int expected)
        {
            int result = _calculator.Calculate(firstNumber, secondNumber, operation);

            Assert.AreEqual(expected, result);
        }

        [TestCase(1, "-", 1, 0)]
        [TestCase(2, "-", 1, 1)]
        public void Calculate_WhenTwoNumbersSubtracted_ResultIsSubtraction(int firstNumber, string operation, int secondNumber, int expected)
        {
            int result = _calculator.Calculate(firstNumber, secondNumber, operation);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Calculate_WhenTwoNumbersAdded_ResultIsWrittenToLog()
        {
            int firstNumber = 1;
            int secondNumber = 1;
            string operation = "+";

            int result = _calculator.Calculate(firstNumber, secondNumber, operation);

            Assert.IsTrue(_logger   .Contains("Result = 2"));
        }
    }
}
