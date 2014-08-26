using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Tests.Acceptance
{
    [TestFixture]
    public class CalculatorEndToEndTests
    {
        private ApplicationRunner _application;

        [SetUp]
        public void Setup()
        {
            _application = new ApplicationRunner();
        }

        [Test]
        public void CalculatorAddsTwoNumbersTogether()
        {
            _application.Displays("Enter a number : ");
            _application.UserInputs("1");
            _application.Displays("Enter a number : ");
            _application.UserInputs("1");
            _application.Displays("Enter an operator : ");
            _application.UserInputs("+");
            _application.Displays("Result = 2");
        }

        [Test]
        public void CalculatorValidatesOutOfBoundsIntergersForFirstNumber()
        {
            _application.Displays("Enter a number : ");
            _application.UserInputs("99999999999");
            _application.DisplayContains("Error");
        }

        [Test]
        public void CalculatorValidatesOutOfBoundsIntergersForSecondNumber()
        {
            _application.Displays("Enter a number : ");
            _application.UserInputs("1");
            _application.Displays("Enter a number : ");
            _application.UserInputs("99999999999");
            _application.DisplayContains("Error");
        }

        [Test]
        public void CalculatorValidatesNonNumericCharactersForIntergers()
        {
            _application.Displays("Enter a number : ");
            _application.UserInputs("a");
            _application.DisplayContains("Error");
        }

        [Test]
        public void CalculatorValidatesOperatorIsKnownCharacter()
        {
            _application.Displays("Enter a number : ");
            _application.UserInputs("1");
            _application.Displays("Enter a number : ");
            _application.UserInputs("1");
            _application.Displays("Enter an operator : ");
            _application.UserInputs("a");
            _application.DisplayContains("Error");
        }
    }
}