using System;
using ParityBitCount.Services.Conditions;
using ParityBitCount.Services.IteratorMutators;

namespace ParityBitCount.Services.ActionableEntityRunner
{
    public class BasicActionableEntityRunner<T> : IActionableEntityRunner<T>
    {
        public void RunOnEntity(T entity, IIteratorMutator<T> mutator, Action<T> action, ICondition<T> actionCondition, ICondition<T> iterationCondition){
            while (iterationCondition.Applies(entity)){
                if (actionCondition.Applies(entity)){
                    action(entity);
                }
                entity = mutator.Mutate(entity);
            }
        }
    }
}