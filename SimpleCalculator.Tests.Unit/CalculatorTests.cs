﻿using NUnit.Framework;
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
        public void Calculate_WhenTwoNumbersAdded_ResultIsAddition(int firstNumber, string operation, int secondNumber, int expected)
        {
            Calculator calculator = new Calculator();

            int result = calculator.Calculate(firstNumber, secondNumber, operation);

            Assert.AreEqual(expected, result);
        }
    }
}