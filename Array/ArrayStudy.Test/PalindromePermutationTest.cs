using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class PalindromePermutationTest
    {
          PalindromePermutation classPalindrome = new PalindromePermutation();

        [Fact]
        public void WhenEmptyReturnTrue()
        {
            bool result = classPalindrome.IsPalindrome("");
            
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcbac")]
        [InlineData("ccddeeffgg")]
        public void WhenNoOddReturnTrue(string str)
        {
            bool result = classPalindrome.IsPalindrome(str);
            
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcbacd")]
        [InlineData("ccddeeffggh")]
        public void WhenOneOddReturnTrue(string str)
        {
            bool result = classPalindrome.IsPalindrome(str);
            
            Assert.True(result);
        }

        [Theory]
        [InlineData("abcbacde")]
        [InlineData("ccddeeffgghhiok")]
        public void WhenMultipleOddReturnFalse(string str)
        {
            bool result = classPalindrome.IsPalindrome(str);
            
            Assert.False(result);
        }

    }
}
