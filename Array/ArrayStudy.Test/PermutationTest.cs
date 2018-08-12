using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class PermutationTest
    {
        Permutation classIsPermutation = new Permutation();

        [Fact]
        public void WhenEmptyReturnTrue()
        {
            bool isPermutation = classIsPermutation.IsPermutation("","");
            {
                
            }
            Assert.True(isPermutation);
        }

        [Theory]
        [InlineData("1","12")]
        public void WhenNotEqualLengthReturnFalse(string str1, string str2)
        {
            bool isPermutation = classIsPermutation.IsPermutation(str1,str2);
        //Then
            Assert.False(isPermutation);
        }

        [Theory]
        [InlineData("11","12")]
        [InlineData("1231#","#2341")]
        [InlineData("#123#!*&)(","*&^%$#2348")]
        public void WhenNotPermutationReturnFalse(string str1,string str2)
        {
        //Given
        //When
            bool isPermutation = classIsPermutation.IsPermutation(str1,str2);
        //Then
            Assert.False(isPermutation);
        }

        [Theory]
        [InlineData("123","123")]
        [InlineData("123#","#321")]
        [InlineData("#123$%^&*()",")(*&^%$#312")]
        public void WhenUPermutationReturnTrue(string str1, string str2)
        {
        //Given
        //When
            bool isPermutation = classIsPermutation.IsPermutation(str1,str2);
        //Then
            Assert.True(isPermutation);
        }
    }
}
