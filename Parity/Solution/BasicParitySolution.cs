namespace ParityBitCount.Solution
{
    public class BasicParitySolution : IParitySolution
    {
        public int GetParity(int number)
        {
           var oneBits = 0;
            var currentNum = number;
            while (currentNum > 0){
                if (currentNum % 2 != 0)
                {
                    oneBits++;
                }
                currentNum /= 2;
            }
            return oneBits;
        }
    }
}