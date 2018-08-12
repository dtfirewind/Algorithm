using System;
using Xunit;
using ArrayStudy.Domain;

namespace ArrayStudy.Test
{
    public class RotateMatrixTest
    {
        RotateMatrix classRM = new RotateMatrix();
        

        [Fact]
        public void WhenNotValidReturnOriginal()
        {
        //Given
            int[][] matrix = new int[4][];
            matrix[0] = new int[3];
            matrix[1] = new int[3];
            matrix[2] = new int[3];
            matrix[3] = new int[3];
            matrix[0][0] = 0;
            matrix[0][1] = 1;
            matrix[0][2] = 2;
            // matrix[0][3] = 3;
            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;
            // matrix[1][3] = 7;
            matrix[2][0] = 8;
            matrix[2][1] = 9;
            matrix[2][2] = 10;
            // matrix[2][3] = 11;
            matrix[3][0] = 12;
            matrix[3][1] = 13;
            matrix[3][2] = 14;
            // matrix[3][3] = 15;

        //When
            int[][] rotatedMatrix = classRM.rotate(matrix);
        //Then
            Assert.Equal(matrix,rotatedMatrix);
        }

        [Fact]
        public void WhenValidReturnRotated()
        {
        //Given
            int[][] matrix = new int[4][];
            matrix[0] = new int[4];
            matrix[1] = new int[4];
            matrix[2] = new int[4];
            matrix[3] = new int[4];
            matrix[0][0] = 0;
            matrix[0][1] = 1;
            matrix[0][2] = 2;
            matrix[0][3] = 3;
            matrix[1][0] = 4;
            matrix[1][1] = 5;
            matrix[1][2] = 6;
            matrix[1][3] = 7;
            matrix[2][0] = 8;
            matrix[2][1] = 9;
            matrix[2][2] = 10;
            matrix[2][3] = 11;
            matrix[3][0] = 12;
            matrix[3][1] = 13;
            matrix[3][2] = 14;
            matrix[3][3] = 15;

            int[][] expectedMatrix = new int[4][];
            expectedMatrix[0] = new int[4];
            expectedMatrix[1] = new int[4];
            expectedMatrix[2] = new int[4];
            expectedMatrix[3] = new int[4];
            expectedMatrix[0][0] = 12;
            expectedMatrix[0][1] = 8;
            expectedMatrix[0][2] = 4;
            expectedMatrix[0][3] = 0;
            expectedMatrix[1][0] = 13;
            expectedMatrix[1][1] = 9;
            expectedMatrix[1][2] = 5;
            expectedMatrix[1][3] = 1;
            expectedMatrix[2][0] = 14;
            expectedMatrix[2][1] = 10;
            expectedMatrix[2][2] = 6;
            expectedMatrix[2][3] = 2;
            expectedMatrix[3][0] = 15;
            expectedMatrix[3][1] = 11;
            expectedMatrix[3][2] = 7;
            expectedMatrix[3][3] = 3;
        //When
            int[][] rotatedMatrix = classRM.rotate(matrix);
        //Then
            Assert.Equal(expectedMatrix,rotatedMatrix);
        }
    }
}