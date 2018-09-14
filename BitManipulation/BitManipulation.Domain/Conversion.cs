using System;
using System.Text;

namespace BitManipulation.Domain
{
    public class Conversion
    {
        public int GetBits(int n, int m)
        {
            int bits = 0;
            for(int c = n ^ m; c != 0; c >>= 1)
            {
                bits += c & 1;
            }

            return bits;
        }
    }

}