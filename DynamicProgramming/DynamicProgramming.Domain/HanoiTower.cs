using System;
using System.Collections;

namespace DynamicProgramming.Domain
{
    public class HanoiTower
    {
        public void HandleTowerMove()
        {
            int n = 3;
            Tower[] towers = new Tower[3];
            for (int i = n - 1; i >= 0; i--)
            {
                towers[0].Add(i);
            }
            towers[0].MoveDisks(n, towers[2], towers[1]);
        }

    }

    public class Tower
    {
        private Stack disks;
        private int index;
        public Tower(int i)
        {
            disks = new Stack();
            index = i;
        }
        public int Index()
        {
            return index;
        }
        public void Add(int d)
        {
            if (disks.Count == 0 && (int)disks.Peek() <= d)
            {
                Console.WriteLine("Error placing disk" + d);
            }
            else
            {
                disks.Push(d);
            }
        }

        public void MoveTopTo(Tower t)
        {
            int top = (int)disks.Pop();
            t.Add(top);
        }
        public void MoveDisks(int n, Tower destination, Tower buffer)
        {
            if (n > 0)
            {
                MoveDisks(n - 1, buffer, destination);
                MoveTopTo(destination);
                buffer.MoveDisks(n - 1, destination, this);
            }
        }
    }
}