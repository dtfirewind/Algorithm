using Xunit;
using BitManipulation.Domain;

namespace BitManipulation.Test
{   
    public class ConversionTest
    {

        [Theory]
        [InlineData(12,3,4)]
        public void TestGetNext(int n, int m, int expected)
        {
        //Given
            Conversion test = new Conversion();
            
        //When
            int result = test.GetBits(n, m);
        //Then
            Assert.Equal(expected,result);
        }
    }
}