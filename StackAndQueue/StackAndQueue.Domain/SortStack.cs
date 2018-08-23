using System;

namespace StackAndQueue.Domain
{   
    public class SortStack
    {
        MyStack<int> stack;

        MyStack<int> tempStack;

        int temp;

        int size;

        public SortStack(MyStack<int> stack)
        {
            this.stack = stack;
        }

        public bool Sort()
        {
            if (stack.IsEmpty()) return false;

            while (!stack.IsEmpty())
            {
                int top = stack.Pop();
                while (!tempStack.IsEmpty() && tempStack.Peek() > top)
                {
                    stack.Push(tempStack.Pop());
                }
                tempStack.Push(top);
            }

            while(!tempStack.IsEmpty())
            {
                stack.Push(tempStack.Pop());
            }
            return true;
        }
    }
}