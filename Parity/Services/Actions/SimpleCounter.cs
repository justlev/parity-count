namespace ParityBitCount.Services.Actions
{
    public class SimpleCounter<T> : ISimpleCounter<T>
    {
        public SimpleCounter()
        {
            Counter = 0;    
        }

        public int Counter {get; private set;}

        public void Count(T input)
        {
            Counter++;
        }
    }
}