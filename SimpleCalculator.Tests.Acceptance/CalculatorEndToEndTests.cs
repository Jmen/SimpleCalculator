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
        [Test]
        public void CalculatorAddsTwoNumbersTogether()
        {
            ApplicationRunner application = new ApplicationRunner();

            application.Displays("Enter a number : ");
            application.UserInputs("1");
            application.Displays("Enter a number : ");
            application.UserInputs("1");
            application.Displays("Enter an operator : ");
            application.UserInputs("+");
            application.Displays("Result = 2");
        }

        [Test]
        public void CalculatorValidatesOutOfBoundsIntergersForFirstNumber()
        {
            ApplicationRunner application = new ApplicationRunner();

            application.Displays("Enter a number : ");
            application.UserInputs("99999999999");
            application.DisplayContains("Error");
        }

        [Test]
        public void CalculatorValidatesOutOfBoundsIntergersForSecondNumber()
        {
            ApplicationRunner application = new ApplicationRunner();

            application.Displays("Enter a number : ");
            application.UserInputs("1");
            application.Displays("Enter a number : ");
            application.UserInputs("99999999999");
            application.DisplayContains("Error");
        }

        [Test]
        public void CalculatorValidatesNonNumericCharactersForIntergers()
        {
            ApplicationRunner application = new ApplicationRunner();

            application.Displays("Enter a number : ");
            application.UserInputs("a");
            application.DisplayContains("Error");
        }

        [Test]
        public void CalculatorValidatesOperatorIsKnownCharacter()
        {
            ApplicationRunner application = new ApplicationRunner();

            application.Displays("Enter a number : ");
            application.UserInputs("1");
            application.Displays("Enter a number : ");
            application.UserInputs("1");
            application.Displays("Enter an operator : ");
            application.UserInputs("a");
            application.DisplayContains("Error");
        }
    }
}