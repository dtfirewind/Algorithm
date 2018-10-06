using System;
using System.Collections.Generic;

namespace DynamicProgramming.Domain
{
    public class EightQueens
    {
        int GRID_SIZE = 8;
        public void PlaceQueen(int row, int[] columns, List<int[]> results)
        {
            if(row == GRID_SIZE) {
                results.Add(columns);
            } else {
                for(int col = 0; col < GRID_SIZE; col++)
                {
                    if(CheckValid(columns, row, col))
                    {
                        columns[row] = col;
                        PlaceQueen(row + 1, columns, results);
                    }
                }
            }
        }

        public bool CheckValid(int[] columns, int row1, int column1)
        {
            for (int row2 = 0; row2 < row1; row2++)
            {
                int column2 = columns[row2];

                if(column1 == column2){
                    return false;
                }

                int columnDistance = Math.Abs(column2 - column1);

                int rowDistance = row1 - row2;
                if(columnDistance == rowDistance)
                {
                    return false;
                }
            }

            return true;
        }
    }
}