using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator.Domain
{
    public class Operations
    {
        private Dictionary<string, Func<int, int, int>> _collection;

        public static Operations GetDefault()
        {
            Operations operations = new Operations();

            operations._collection = new Dictionary<string, Func<int, int, int>>
            {
                {"+", (x, y) => x + y},
                {"-", (x, y) => x - y}
            };

            return operations;
        }

        public Func<int, int, int> Get(string operation)
        {
            return _collection[operation];
        }

        public bool Valid(string result)
        {
            return _collection.ContainsKey(result);
        }
    }
}
