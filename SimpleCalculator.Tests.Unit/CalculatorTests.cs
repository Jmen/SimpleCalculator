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
        [TestCase(1, "+", 1, 2)]
        [TestCase(1, "+", 2, 3)]
        public void Calculate_WhenTwoNumbersAdded_ResultIsAddition(int firstNumber, string operation, int secondNumber, int expected)
        {
            MockLogger logger = new MockLogger();
            Calculator calculator = new Calculator(logger);

            int result = calculator.Calculate(firstNumber, secondNumber, operation);

            Assert.AreEqual(expected, result);
        }

        [TestCase(1, "-", 1, 0)]
        [TestCase(2, "-", 1, 1)]
        public void Calculate_WhenTwoNumbersSubtracted_ResultIsSubtraction(int firstNumber, string operation, int secondNumber, int expected)
        {
            MockLogger logger = new MockLogger();
            Calculator calculator = new Calculator(logger);

            int result = calculator.Calculate(firstNumber, secondNumber, operation);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Calculate_WhenTwoNumbersAdded_ResultIsWrittenToLog()
        {
            MockLogger logger = new MockLogger();
            Calculator calculator = new Calculator(logger);

            int firstNumber = 1;
            int secondNumber = 1;
            string operation = "+";

            int result = calculator.Calculate(firstNumber, secondNumber, operation);

            Assert.IsTrue(logger.Contains("Result = 2"));
        }
    }
}
