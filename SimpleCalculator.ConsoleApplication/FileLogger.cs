using SimpleCalculator.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SimpleCalculator.ConsoleApplication
{
    class FileLogger : ILogger
    {
        public void Write(string text)
        {
            File.WriteAllText("SimpleCalculator.log", text + Environment.NewLine);
        }
    }
}
