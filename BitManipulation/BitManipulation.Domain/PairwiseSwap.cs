using System;
using System.Text;

namespace BitManipulation.Domain
{
    public class PairwiseSwap
    {
        public uint SwapBits(uint n)
        {
            return ( (( n & 0xaaaaaaaa) >> 1) | ((n & 0x55555555) << 1));
        }
    }

}