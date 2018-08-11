using System;
using ParityBitCount.Services.ActionableEntityRunner;
using ParityBitCount.Services.Actions;
using ParityBitCount.Services.Conditions;
using ParityBitCount.Services.IteratorMutators;
using ParityBitCount.Solution;

namespace ParityBitCount
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var number = GetNumberFromArguments(args);
            if (number == -1) return;
            Console.WriteLine("InputNumber: {0}", number);
            /// Basic Solution - O(log(n))
            System.Console.WriteLine("Basic Solution");
            var basicSolution = new BasicParitySolution();
            var result = basicSolution.GetParity(number);
            Console.WriteLine("Result is: {0}", result);


            // Over Engineered Solution
            System.Console.WriteLine("OverEngineered Solution");
            var genericSolution = new SuperGenericParitySolution();
            result = basicSolution.GetParity(number);
            Console.WriteLine("Result is: {0}", result);
        }

        private static int GetNumberFromArguments(string[] args)
        {
            var toReturn = -1;
            if (args.Length < 1)
            {
                System.Console.WriteLine("Need to pass in an argument. It has to be an integer.");
            }
            
            if(!int.TryParse(args[0], out toReturn))
            {
                System.Console.WriteLine("Wrong type of argument.");
            }
            if (toReturn < 0)
            {
                System.Console.WriteLine("Has to be a positive number.");
            }
            return toReturn;
        }
    }
}
