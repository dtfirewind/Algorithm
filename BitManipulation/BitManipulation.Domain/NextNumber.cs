using System;
using System.Text;

namespace BitManipulation.Domain
{
    public class NextNumber
    {
        public int GetNext(int n)
        {
            int c0 = 0, c1= 0, c = n;

            while((c & 1) == 0 && c != 0){
                c0++;
                c >>= 1;
            }

            while((c & 1) == 1){
                c1++;
                c >>= 1;
            }

            if(c0 + c1 == 31 || c0 + c1 == 0){
                return -1;
            }

            int p = c1 + c0;

            n |= (1 << p);
            n &= ~((1 << p) - 1);
            n |= (1 << (c1 - 1)) - 1;

            return n;
        }

        public int getPrev(int n) {
            int temp = n;
            int c0 = 0, c1 = 0;

            while((temp & 1) == 1){
                c1++;
                temp >>= 1;
            }

            if(temp == 0) return -1;

            while ((temp & 1) == 0 && temp != 0) 
            {
                c0++;
                temp >>= 1;
            }

            int p = c0 + c1; // position of rightmost non-trailing one
            n &= ((~0) << (p + 1)); // clears from bit p onwards
            int mask= (1 << (c1 + 1)) - 1; // Sequence of (cl+l) ones
            n |= mask << (c0 - 1);
            return n;
        }
    }

}