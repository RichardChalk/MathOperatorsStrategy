using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Subtraction : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
}
