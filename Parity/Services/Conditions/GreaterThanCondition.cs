using System;

namespace ParityBitCount.Services.Conditions
{
    public class GreaterThanCondition<T> : ICondition<T> where T : IComparable
    {
        private T _compareTo;

        public GreaterThanCondition(T compareTo)
        {
            _compareTo = compareTo;
        }

        public bool Applies(T input)
        {   
            return input.CompareTo(_compareTo) > 0;
        }
    }
}