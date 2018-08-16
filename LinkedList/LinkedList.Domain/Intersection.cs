using System;

namespace LinkedList.Domain
{
    public class Intersection
    {
        public SinglyLinkedListNode GetIntersection(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            if(node1 == null || node2 == null){
                return null;
            }

            Result result1 = GetTailAndSize(node1);
            Result result2 = GetTailAndSize(node2);

            if(result1.tail != result2.tail){
                return null;
            }

            SinglyLinkedListNode shorter = result1.size < result2.size ? node1 : node2;
            SinglyLinkedListNode longer = result1.size < result2.size ? node2 : node1;

            longer = GetKthNode(longer, Math.Abs(result1.size - result2.size));

            while(shorter != longer){
                shorter = shorter.next;
                longer = longer.next;
            }

            return longer;
        }

        private Result GetTailAndSize(SinglyLinkedListNode node)
        {
            if(node == null){
                return null;
            }

            int size = 1;
            SinglyLinkedListNode current = node;
            while(current != null){
                size++;
                current = current.next;
            }
            return new Result(current,size);
        }

        public SinglyLinkedListNode GetKthNode(SinglyLinkedListNode node, int k)
        {
            SinglyLinkedListNode current = node;
            while(k > 0 && current != null)
            {
                current = current.next;
                k--;
            }
            return current;
        }
    }

    public class Result
    {
        public SinglyLinkedListNode tail;
        public int size;
        public Result(SinglyLinkedListNode tail, int size)
        {
            this.size = size;
            this.tail = tail;
        }
    }
}