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

            _process.StartInfo.FileName = "SimpleCalculator.ConsoleApplication.exe";
            _process.StartInfo.UseShellExecute = false;
            _process.StartInfo.RedirectStandardOutput = true;
            _process.StartInfo.RedirectStandardInput = true;

            _process.Start();
        }

        ~ApplicationRunner()
        {
            if (!_process.HasExited)
            {
                _process.Kill();
            }
        }

        internal void Displays(string expectedText)
        {
            Assert.AreEqual(expectedText, _process.StandardOutput.ReadLine());
        }

        internal void DisplayContains(string expectedText)
        {
            Assert.IsTrue(_process.StandardOutput.ReadLine().Contains(expectedText));
        }

        internal void UserInputs(string inputText)
        {
            _process.StandardInput.WriteLine(inputText);
        }
    }
}
