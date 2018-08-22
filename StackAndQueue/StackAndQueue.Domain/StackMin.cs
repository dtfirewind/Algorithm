using System;

namespace StackAndQueue.Domain
{
    public class StackMin : MyStack<int>
    {
        MyStack<int> s2;

        public StackMin(){
            s2 = new MyStack<int>();
        }
        public void Push(int value)
        {
            if (value <= Min())
            {
                s2.Push(value);
            }
            base.Push(value);
        }

        public int Pop()
        {
            int value = base.Pop();
            if(value == Min())
            {
                s2.Pop();
            }
            return value;
        }

        public int Min()
        {
            if(s2.IsEmpty())
            {
                return int.MaxValue;
            } else {
                return s2.Peek();
            }
        }
    }
}