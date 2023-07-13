using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            HoldsChosenStrategy strategy = new HoldsChosenStrategy();

            strategy.SetStrategy(new Addition());
            Console.WriteLine("Addition strat: 6+2 = " + strategy.ExecuteStrategy(6, 2));

            strategy.SetStrategy(new Subtraction());
            Console.WriteLine("Subtraction strat: 6-2 = " + strategy.ExecuteStrategy(6, 2));

            strategy.SetStrategy(new Multiplication());
            Console.WriteLine("Multiplication strat: 6*2 = " + strategy.ExecuteStrategy(6, 2));

            strategy.SetStrategy(new Division());
            Console.WriteLine("Division strat: 6/2 = " + strategy.ExecuteStrategy(6, 2));

            Console.ReadLine();
        }
    }
}
