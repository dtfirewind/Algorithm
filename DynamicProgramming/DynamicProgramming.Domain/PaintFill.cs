using System;

namespace DynamicProgramming.Domain
{
    public class PaintFill
    {
        public enum Color
        {
            Black, White, Red, Yellow, Green
        }

        public bool FillPaint(Color[][] screen, int r, int c, Color nColor)
        {
            if(screen[r][c] == nColor) return false;
            return FillPaint(screen, r, c, screen[r][c], nColor);
        }

        public bool FillPaint(Color[][] screen, int r, int c, Color oColor, Color nColor)
        {
             if (r < 0 || r >= screen.Length || c < 0 || c >= screen[0].Length){
                 return false;
             }

             if(screen[r][c] == oColor)
             {
                 screen[r][c] = nColor;
                 FillPaint(screen, r - 1, c, oColor, nColor);
                 FillPaint(screen, r + 1, c, oColor, nColor);
                 FillPaint(screen, r, c - 1, oColor, nColor);
                 FillPaint(screen, r, c + 1, oColor, nColor);
             }
             return true;
        }
    }
}