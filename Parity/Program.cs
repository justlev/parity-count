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
            var number = int.Parse(args[0]);
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
    }
}
