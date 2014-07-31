using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleCalculator.Domain;

namespace SimpleCalculator.Tests.Unit
{
    class MockLogger : ILogger
    {
        string _textWritten;

        public void Write(string text)
        {
 	        _textWritten = text;
        }

        internal bool Contains(string expectedText)
        {
            return (_textWritten.Contains(expectedText));
        }
    }
}
