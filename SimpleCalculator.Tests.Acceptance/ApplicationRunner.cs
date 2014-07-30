using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SimpleCalculator.Tests.Acceptance
{
    class ApplicationRunner
    {
        Process _process;

        public ApplicationRunner()
        {
            _process = new Process();

            _process.StartInfo.FileName = "SimpleCalculator.Application.exe";
            _process.StartInfo.UseShellExecute = false;
            _process.StartInfo.RedirectStandardOutput = true;
            _process.StartInfo.RedirectStandardInput = true;

            _process.Start();
        }

        internal void Displays(string expectedText)
        {
            Assert.AreEqual(expectedText, _process.StandardOutput.ReadLine());
        }

        internal void UserInputs(string inputText)
        {
            _process.StandardInput.WriteLine(inputText);
        }
    }
}
