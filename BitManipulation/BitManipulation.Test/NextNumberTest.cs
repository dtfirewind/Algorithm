using Xunit;
using BitManipulation.Domain;

namespace BitManipulation.Test
{   
    public class NextNumberTest
    {

        [Theory]
        [InlineData(3,5)]
        public void TestGetNext(int num, int expected)
        {
        //Given
            NextNumber test = new NextNumber();
            
        //When
            int result = test.GetNext(num);
        //Then
            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData(5,3)]
        public void TestGetPrev(int num, int expected)
        {
        //Given
            NextNumber test = new NextNumber();
            
        //When
            int result = test.getPrev(num);
        //Then
            Assert.Equal(expected,result);
        }
    }
}