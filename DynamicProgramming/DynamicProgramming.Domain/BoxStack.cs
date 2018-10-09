using System;
using System.Collections.Generic;

namespace DynamicProgramming.Domain
{
    public class BoxStack
    {
        public int CreateStack(List<Box> boxes)
        {
            boxes.Sort(new BoxComparator());
            int maxHeight = 0;
            int[] stackMap = new int[boxes.Count];
            for(int i=0;i < boxes.Count; i++)
            {
                int height = CreateStack(boxes, i, stackMap);
                maxHeight = Math.Max(maxHeight, height);
            }
            return maxHeight;
        }

        public int CreateStack(List<Box> boxes, int bottomIndex, int[] stackMap)
        {
            if(bottomIndex < boxes.Count && stackMap[bottomIndex] > 0){
                return stackMap[bottomIndex];
            }
            Box bottom = boxes[bottomIndex];
            int maxHeight = 0;
            for(int i = bottomIndex + 1; i < boxes.Count; i++)
            {
                if(boxes[i].CanBeAbove(bottom)){
                    int height = CreateStack(boxes, i, stackMap);
                    maxHeight = Math.Max(height, maxHeight);
                }
            }
            maxHeight += bottom.Height;
            stackMap[bottomIndex] = maxHeight;
            return maxHeight;
        }
    }

    public class Box
    {
        public int Height;
        public int Width;
        public int Depth;
        public bool CanBeAbove(Box box){
            return this.Height > box.Height && this.Width > box.Width && this.Depth > box.Depth;
        }
    }

    public class BoxComparator : IComparer<Box>
    {
        public int Compare(Box x, Box y)
        {
            return y.Height - x.Height;
        }
    }
}