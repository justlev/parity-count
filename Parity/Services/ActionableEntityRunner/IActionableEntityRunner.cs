using System;
using ParityBitCount.Services.Conditions;
using ParityBitCount.Services.IteratorMutators;

namespace ParityBitCount.Services.ActionableEntityRunner
{
    public interface IActionableEntityRunner<T>
    {
        void RunOnEntity(T entity, IIteratorMutator<T> mutator, Action<T> action, ICondition<T> actionCondition, ICondition<T> iterationCondition);
    }
}