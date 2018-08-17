using System;

namespace StackAndQueue.Domain
{
    public class MyStack<T>
    {
        private class StackNode
        {
            public T data;
            public StackNode next;

            public StackNode(T data)
            {
                this.data = data;
            }
        }

        private StackNode top;

        public T Pop()
        {
            if(top == null) throw new InvalidOperationException();
            T item = top.data;
            top = top.next;
            return item;
        }

        public void Push(T item)
        {
            StackNode t = new StackNode(item);
            t.next = top;
            top = t;
        }

        public T Peek()
        {
            if(top == null) throw new InvalidOperationException();
            return top.data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }
    }
}