using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class UrlifyTest
    {
          Urlify classUrlify = new Urlify();

        [Fact]
        public void WhenEmptyReturnEmpty()
        {
            string result = classUrlify.UrlifyString("");
            
            Assert.Equal("",result);
        }

        [Theory]
        [InlineData("123","123")]
        [InlineData("https://www.dmt.ca","https://www.dmt.ca")]
        public void WhenNoSpaceReturnOriginal(string str, string expected)
        {
            string result = classUrlify.UrlifyString(str);
            
            Assert.Equal(expected,result);
        }

        
        [Theory]
        [InlineData("1 2  3","1%202%20%203")]
        [InlineData("https://www.dmt.ca?value=123 456","https://www.dmt.ca?value=123%20456")]
        public void WhenSpaceReturnReplaceSpace(string str,string expected)
        {
            string result = classUrlify.UrlifyString(str);
            
            Assert.Equal(expected,result);
        }
    }
}
