using System;
using System.Text;

namespace BitManipulation.Domain
{
    public class FlipBitToWin
    {
        public int FindLongestSequence(int num)
        {
            if(~num == 0) return 4 * 8;

            int currentLength = 0;
            int previousLength = 0;

            int maxLength = 1;

            while(num != 0)
            {
                if((num & 1) == 1){
                    currentLength++;
                }else if((num & 1) == 0){
                    currentLength = 0;
                    previousLength = (num & 2) == 0 ? 0 : currentLength;
                }
                maxLength = Math.Max(previousLength + currentLength + 1, maxLength);
                num >>= 1;
            }
            return maxLength;
        }
    }
}