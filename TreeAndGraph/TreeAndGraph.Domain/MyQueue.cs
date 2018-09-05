using System;

namespace TreeAndGraph.Domain
{
    public class MyQueue<T>
    {
        private class QueueNode
        {
            public T data;
            public QueueNode next;

            public QueueNode(T item)
            {
                this.data = item;
            }
        }

        private QueueNode first;
        private QueueNode last;

        public void Add(T item)
        {
            QueueNode t = new QueueNode(item);
            if(last != null)
            {
                last.next = t;
            }
            last = t;
            if(first == null)
            {
                first = last;
            }
        }

        public T Remove()
        {
            if(first == null) throw new InvalidOperationException();
            T data = first.data;
            first = first.next;
            if(first == null)
            {
                last = null;
            }
            return data;
        }

        public T Peek()
        {
            if(first == null) throw new InvalidOperationException();
            return first.data;
        }

        public bool IsEmpty()
        {
            return first == null;
        }
    }
}