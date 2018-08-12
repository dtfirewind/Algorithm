using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class StringRotationTest
    {
        StringRotation classSR = new StringRotation();

        [Fact]
        public void WhenEqualLengthReturnTrue()
        {
        //Given
            bool result = classSR.isRotation("abbaa","aaabb");
        //When
        
        //Then
            Assert.True(result);
        }

        [Fact]
        public void WhenNotEqualLengthReturnFalse()
        {
        //Given
            bool result = classSR.isRotation("abbaaa","aaabb");
        //When
        
        //Then
            Assert.False(result);
        //When
        
        //Then
        }

    }
}