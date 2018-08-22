using System;
using System.Collections.Generic;

namespace StackAndQueue.Domain
{
    public class StackPlate
    {
        List<MyStack<int>> stacks;
        int capacity;
        int size;

        public StackPlate(int capacity)
        {
            stacks = new List<MyStack<int>>();
            this.capacity = capacity;
        }

        public void Push(int data)
        {
            MyStack<int> last = GetLastStack();
            if(last != null && !IsFull())
            {
                last.Push(data);
                size++;
            } else {
                size = 0;
                MyStack<int> stack = new MyStack<int>();
                stack.Push(data);
                stacks.Add(stack);
            }
        }

        public int Pop()
        {
            MyStack<int> last = GetLastStack();
            if(last == null)
            {
                throw new InvalidOperationException();
            }
            int v = last.Pop();
            size--;
            if(size == 0)
            {
                stacks.Remove(last);
            }
            return v;
        }

        public MyStack<int> GetLastStack()
        {
            if(!IsListEmpty()){
                return stacks[stacks.Count - 1];
            } else{
                throw new InvalidOperationException();
            }
        }

        public bool IsListEmpty()
        {
            return stacks.Count == 0;
        }

        public bool IsFull()
        {
            return size < capacity;
        }
    }
}