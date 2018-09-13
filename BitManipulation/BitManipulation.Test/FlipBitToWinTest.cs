using Xunit;
using BitManipulation.Domain;

namespace BitManipulation.Test
{   
    public class FlipBitToWinTest
    {

        [Theory]
        [InlineData(11,3)]
        public void TestIt(int num, int expected)
        {
        //Given
            FlipBitToWin test = new FlipBitToWin();
            
        //When
            int result = test.FindLongestSequence(num);
        //Then
            Assert.Equal(expected,result);
        }
    }
}