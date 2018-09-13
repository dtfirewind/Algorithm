using Xunit;
using BitManipulation.Domain;

namespace BitManipulation.Test
{   
    public class BinaryToStringTest
    {

        [Theory]
        [InlineData(0.5,".1")]
        public void TestIt(double num, string expected)
        {
        //Given
            BinaryToString insertion = new BinaryToString();
            
        //When
            string result = insertion.ConverToString(num);
        //Then
            Assert.Equal(expected,result);
        }
    }
}