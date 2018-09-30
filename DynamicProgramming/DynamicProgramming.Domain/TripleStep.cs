namespace DynamicProgramming.Domain
{
    public class TripleStep
    {
        public int CountWays(int n)
        {
            int[] memo = new int[n + 1];
            for(int i=0;i<memo.Length;i++){
                memo[i] = -1;
            }
            return CountWays(n, memo);
        }

        private int CountWays(int n, int[] memo)
        {
            if(n < 0){
                return 0;
            }else if(n == 0){
                return 1;
            }else if(memo[n] > -1){
                return memo[n];
            }else{
                memo[n] = CountWays(memo[n - 1], memo) + CountWays(memo[n - 2], memo) + CountWays(memo[n - 3], memo);
                return memo[n];
            }
        }
    }
}