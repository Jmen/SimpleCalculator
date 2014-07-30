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
            switch (operation)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                default:
                    throw new Exception("Unknown operator");
            }
        }
    }
}
