using System;

namespace StackAndQueue.Domain
{   
    public class QueueViaStack<T>
    {
        MyStack<T> stackNew, stackOld;

        public QueueViaStack()
        {
            stackNew = new MyStack<T>();
            stackOld = new MyStack<T>();
        }

        public int Size()
        {
            return stackNew.size + stackOld.size;
        }

        public void Add(T value)
        {
            stackNew.Push(value);
        }

        private void ShiftStacks()
        {
            if(stackOld.IsEmpty()){
                while (!stackNew.IsEmpty())
                {
                    stackOld.Push(stackNew.Pop());
                }
            }
        }

        public T Remove()
        {
            ShiftStacks();
            return stackOld.Pop();
        }

        public T Peek()
        {
            ShiftStacks();
            return stackOld.Peek();
        }
    }
}