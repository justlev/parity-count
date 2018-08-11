using System;
using ParityBitCount.Services.ActionableEntityRunner;
using ParityBitCount.Services.Actions;
using ParityBitCount.Services.Conditions;
using ParityBitCount.Services.IteratorMutators;

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
            var result = SimpleParityCount(number);
            Console.WriteLine("Result is: {0}", result);


            // Over Engineered Solution
            System.Console.WriteLine("OverEngineered Solution");
            result = OverEngineeredCount(number);
            Console.WriteLine("Result is: {0}", result);
        }

        // This is the straight-forward solution.
        // Keep dividing by 2 until reaching 0. Every odd number - is a 1.
        private static int SimpleParityCount(int number)
        {
            var oneBits = 0;
            var currentNum = number;
            while (currentNum > 0){
                currentNum /= 2;
                if (currentNum % 2 != 0)
                {
                    oneBits++;
                }
            }
            return oneBits;
        }


        private static int OverEngineeredCount(int number)
        {
            var counter = new SimpleCounter<int>();
            var actionableRunner = new BasicActionableEntityRunner<int>();

            actionableRunner.RunOnEntity(
                number,
                new NumericMutator(2),
                counter.Count,
                new OddNumberCondition(),
                new GreaterThanCondition<int>(0)
            );

            return counter.Counter;
        }
    }
}
