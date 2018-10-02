using System;

namespace DynamicProgramming.Domain
{
    public class RecursiveMultiply
    {
        public int minProduct(int a, int b)
        {
            int bigger = a < b ? b : a;
            int smaller = a > b ? b : a;
            return minProductHelper(smaller, bigger);
        }

        private int minProductHelper(int smaller, int bigger)
        {
            if(smaller == 0) return 0;
            if(smaller == 1) return 1;

            int s = smaller >> 1;
            int side1 = minProduct(s, bigger);
            int side2 = side1;
            if(smaller % 2 == 1){
                side2 = minProductHelper(smaller - s, bigger);
            }

            return side1 + side2;
        }
    }
}