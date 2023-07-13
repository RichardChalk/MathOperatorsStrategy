using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class HoldsChosenStrategy
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy newStrategy)
        {
            _strategy = newStrategy;
        }

        public int ExecuteStrategy(int a, int b)
        {
            return _strategy.Execute(a, b);
        }
    }
}
