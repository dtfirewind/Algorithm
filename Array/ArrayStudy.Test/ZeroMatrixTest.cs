using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class ZeroMatrixTest
    {
        ZeroMatrix classZM = new ZeroMatrix();

        [Fact]
        public void TestZeroMatrix()
        {
            int[,] matrix = new int[4,4];

            bool result = classZM.CheckZero(matrix);

            Assert.True(result);
        }
    }
}