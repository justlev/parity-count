namespace ParityBitCount.Services.Conditions
{
    public interface ICondition<T>
    {
         bool Applies(T input);
    }
}