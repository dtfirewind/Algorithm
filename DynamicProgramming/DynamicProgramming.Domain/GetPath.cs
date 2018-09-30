using System;
using System.Drawing;
using System.Collections.Generic;

namespace DynamicProgramming.Domain
{
    public class GetPath
    {
        public List<Point> CalculatePath(bool[][] maze)
        {
            if(maze == null || maze.Length == 0) return null;
            List<Point> path = new List<Point>();
            if(CalculatePath(maze, maze.Length - 1, maze[0].Length - 1, path))
            {
                return path;
            }
            return null;
        }

        private bool CalculatePath(bool[][] maze, int row, int col, List<Point> path)
        {
            if(row < 0 || col < 0 || !maze[row][col]) return false;

            bool isAtOrigin = (row == 0) && (col == 0);

            if(isAtOrigin || CalculatePath(maze, row - 1, col, path) || CalculatePath(maze, row, col - 1, path)){
                Point p = new Point(row, col);
                path.Add(p);
                return true;
            }

            return false;
        }
    }
}