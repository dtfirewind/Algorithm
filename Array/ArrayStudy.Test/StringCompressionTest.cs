using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class StringCompressionTest
    {
        StringCompression classSC = new StringCompression();

        [Fact]
        public void WhenEmptyStringReturnEmpty()
        {
        //Given
            string str = classSC.CompressString("");
        //When
        
        //Then
            Assert.Equal("",str);
        }

        [Theory]
        [InlineData("abc","abc")]
        [InlineData("aabbcc","aabbcc")]
        [InlineData("aabcccd","aabcccd")]
        public void WhenCompressedLongerReturnOriginal(string originalStr, string expected)
        {
            string str = classSC.CompressString(originalStr);
        //When
        
        //Then
            Assert.Equal(expected,str);
        }

        [Theory]
        [InlineData("aabbccc","a2b2c3")]
        [InlineData("aaabbbcccddd","a3b3c3d3")]
        [InlineData("aaabbbbccd","a3b4c2d1")]
        public void WhenCompressedShorterReturnCompressed(string originalStr, string expected)
        {
            string str = classSC.CompressString(originalStr);
        //When
        
        //Then
            Assert.Equal(expected,str);
        }
    }
}