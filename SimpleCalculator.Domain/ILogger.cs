using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleCalculator.Domain
{
    public interface ILogger
    {
        void Write(string text);
    }
}
