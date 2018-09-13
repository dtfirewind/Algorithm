using Xunit;
using BitManipulation.Domain;

namespace BitManipulation.Test
{   
    public class InsertionTest
    {

        [Theory]
        [InlineData(1024,19,2,6,1100)]
        public void TestInsertion(int n, int m, int i, int j, int expected)
        {
        //Given
            Insertion insertion = new Insertion();
            
        //When
            int result = insertion.InsertBits(n,m,i,j);
        //Then
            Assert.Equal(expected,result);
        }
    }
}