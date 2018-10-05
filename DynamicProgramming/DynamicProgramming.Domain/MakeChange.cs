using System;

namespace DynamicProgramming.Domain
{
    public class MakeChange
    {
        public int CountWays(int amount, int[] denoms, int index)
        {
            if( index >= denoms.Length - 1) return 1;
            int denomAmount = denoms[index];
            int ways = 0;
            for(int i=0;i * denomAmount <= amount; i++)
            {
                int amountRemaining = amount - i * denomAmount;
                ways += CountWays(amountRemaining, denoms, index + 1);
            }
            return ways;
        }

        public int CountWays(int n){
            int[] denoms = {25, 10, 5, 1};
            return CountWays(n, denoms, 0);
        }
    }
}