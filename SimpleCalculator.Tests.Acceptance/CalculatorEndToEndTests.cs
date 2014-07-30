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
        [TestCase]
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
    }
}