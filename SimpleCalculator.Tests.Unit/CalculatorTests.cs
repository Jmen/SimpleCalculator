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
        [Test]
        public void Calculate_WhenTwoNumbersAdded_ResultIsAddition()
        {
            int firstNumber = 1;
            int secondNumber = 1;
            string op = "+";

            Calculator calculator = new Calculator();

            int result = calculator.Calculate(firstNumber, secondNumber, op);

            Assert.AreEqual(2, result);
        }
    }
}
