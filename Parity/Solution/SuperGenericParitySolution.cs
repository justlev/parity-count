using ParityBitCount.Services.ActionableEntityRunner;
using ParityBitCount.Services.Actions;
using ParityBitCount.Services.Conditions;
using ParityBitCount.Services.IteratorMutators;

namespace ParityBitCount.Solution
{
    public class SuperGenericParitySolution : IParitySolution
    {   
        public int GetParity(int number)
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