using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class IsUniqueTest
    {
        IsUnique classIsUnique = new IsUnique();

        [Fact]
        public void WhenEmptyReturnTrue()
        {
            bool isUnique = classIsUnique.IsUniqueStr("");
            {
                
            }
            Assert.True(isUnique);
        }

        [Theory]
        [InlineData("11")]
        [InlineData("1231#")]
        [InlineData("#123#")]
        public void WhenNotUniqueReturnFalse(string str)
        {
        //Given
        //When
            bool isUnique = classIsUnique.IsUniqueStr(str);
        //Then
            Assert.False(isUnique);
        }

        [Theory]
        [InlineData("1")]
        [InlineData("123#")]
        [InlineData("#123")]
        public void WhenUniqueReturnTrue(string str)
        {
        //Given
        //When
            bool isUnique = classIsUnique.IsUniqueStr(str);
        //Then
            Assert.True(isUnique);
        }
    }
}
