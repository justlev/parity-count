namespace ParityBitCount.Services.Actions
{
    public interface ISimpleCounter<T>
    {
        int Counter {get;}
         void Count(T input);
    }
}