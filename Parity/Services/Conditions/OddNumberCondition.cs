namespace ParityBitCount.Services.Conditions
{
    public class OddNumberCondition : ICondition<int>
    {
        public bool Applies(int input)
        {
            return input % 2 != 0;
        }
    }
}