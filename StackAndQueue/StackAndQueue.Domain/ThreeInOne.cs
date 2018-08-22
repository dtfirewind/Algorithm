using System;

namespace StackAndQueue.Domain
{
    public class ThreeInOne
    {
        private int numOfStack;
        private int stackCapacity;
        public int[] sizes;
        private int[] values;

        public ThreeInOne(int numOfStack, int stackCapacity)
        {
            this.numOfStack = numOfStack;
            sizes = new int[numOfStack];
            this.stackCapacity = stackCapacity;
            values = new int[numOfStack * stackCapacity];
        }

        public void Push(int stackNum, int data)
        {
            if(IsFull(stackNum)){
                throw new InvalidOperationException();
            }

            sizes[stackNum]++;
            values[IndexOfTop(stackNum)] = data;
        }

        public int Pop(int stackNum)
        {
            if(IsEmpty(stackNum))
            {
                throw new InvalidOperationException();
            }
            int value = values[IndexOfTop(stackNum)];
            sizes[stackNum]--;
            values[IndexOfTop(stackNum)] = 0;
            return value;
        }

        public int Peek(int stackNum)
        {
            if(IsEmpty(stackNum))
            {
                throw new InvalidOperationException();
            }

            int value = values[IndexOfTop(stackNum)];
            return value;
        }

        private bool IsEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        private bool IsFull(int stackNum)
        {
            return sizes[stackNum] == stackCapacity;
        }

        private int IndexOfTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];
            return offset + size - 1;
        }
    }
}