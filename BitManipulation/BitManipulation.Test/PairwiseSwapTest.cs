using Xunit;
using BitManipulation.Domain;

namespace BitManipulation.Test
{   
    public class PairwiseSwapTest
    {

        [Theory]
        [InlineData(9,6)]
        [InlineData(32,16)]
        public void TestSwapBits(uint n, uint expected)
        {
        //Given
            PairwiseSwap test = new PairwiseSwap();
            
        //When
            uint result = test.SwapBits(n);
        //Then
            Assert.Equal(expected,result);
        }
    }
}