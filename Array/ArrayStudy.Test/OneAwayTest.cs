using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class OneAwayTest
    {
        OneAway classOneAway = new OneAway();

        [Fact]
        public void WhenEmptyReturnTrue()
        {
        //Given
            bool result = classOneAway.IsOneEditAway("","");
        //When
        
        //Then
            Assert.True(result);
        }

        [Theory]
        [InlineData("str1","str234")]
        [InlineData("str123","str123145")]
        public void WhenMultipleDifferenceReturnFalse(string str1, string str2)
        {
        //Given
            bool result = classOneAway.IsOneEditAway(str1,str2);
        //When
        
        //Then
            Assert.False(result);
        }

        [Theory]
        [InlineData("str1","str2",true)]
        [InlineData("str123,","str2345",false)]
        public void WhenSameLengthReturnResult(string str1, string str2, bool expected)
        {
            bool result = classOneAway.IsOneEditAway(str1, str2);
            //When

            //Then
            Assert.Equal(expected,result);
        }

        [Theory]
        [InlineData("str1","str13",true)]
        [InlineData("str123,","str23,",true)]
        [InlineData("!str1","str1",true)]
        [InlineData("!str1","str2",false)]
        public void WhenOneLengthDifferenceReturnResult(string str1, string str2, bool expected)
        {
            bool result = classOneAway.IsOneEditAway(str1, str2);
            //When

            //Then
            Assert.Equal(expected,result);
        }
    }
}