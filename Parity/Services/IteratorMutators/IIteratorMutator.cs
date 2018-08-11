namespace ParityBitCount.Services.IteratorMutators
{
    public interface IIteratorMutator<T>
    {
         T Mutate(T input);
    }
}