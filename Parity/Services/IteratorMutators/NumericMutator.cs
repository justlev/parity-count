namespace ParityBitCount.Services.IteratorMutators
{
    public class NumericMutator : IIteratorMutator<int>
    {
        private int _divideBy;

        public NumericMutator(int divideBy = 2)
        {
            _divideBy = divideBy;    
        }

        public int Mutate(int input)
        {
            return input / _divideBy;
        }
    }
}