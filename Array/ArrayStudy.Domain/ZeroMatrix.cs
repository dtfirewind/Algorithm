using System;

namespace ArrayStudy.Domain
{
    public class ZeroMatrix
    {
        public bool CheckZero(int[,] matrix)
        {
            bool[] row = new bool[matrix.GetLength(0)];
            bool[] column = new bool[matrix.GetLength(1)];

            for(int i=0;i<matrix.GetLength(0);i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    if(matrix[i,j] == 0){
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            for(int j=0;j<row.Length;j++)
            {
                if(row[j]) ZerofyRow(matrix, j);
            }

            for(int j=0;j<column.Length;j++)
            {
                if(column[j]) ZerofyColumn(matrix, j);
            }

            return true;
        }

        

        private void ZerofyRow(int[,] matrix, int row)
        {
            for(int j=0;j<matrix.GetLength(1);j++)
            {
                matrix[row,j] = 0;
            }
        }

        private void ZerofyColumn(int[,] matrix, int column)
        {
            for(int j=0;j<matrix.GetLength(0);j++)
            {
                matrix[j,column] = 0;
            }
        }
    }
}