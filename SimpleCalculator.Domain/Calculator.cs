using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator.Domain
{
    public class Calculator
    {
        public int Calculate(int firstNumber, int secondNumber, string operation)
        {
            if (operation == "-")
                return 0;
            return firstNumber + secondNumber;
        }
    }
}
