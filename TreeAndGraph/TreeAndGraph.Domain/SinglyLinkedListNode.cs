namespace TreeAndGraph.Domain
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> next = null;
        public int data;

        public SinglyLinkedListNode(int data)
        {
            this.data = data;
        }

        public SinglyLinkedListNode()
        {
            
        }

        public void AppendToTail(int data)
        {
            SinglyLinkedListNode<T> node = new SinglyLinkedListNode<T>(data);
            SinglyLinkedListNode<T> n = this;

            while(n.next != null)
            {
                n = n.next;
            }
            n.next = node;
        }

        public SinglyLinkedListNode<T> DeleteNode(SinglyLinkedListNode<T> head, int data)
        {
            SinglyLinkedListNode<T> n = head;

            if(n.data == data){
                return head.next;
            }

            while(n.next != null)
            {
                if(n.next.data == data)
                {
                    n.next = n.next.next;
                    return head;
                }
                n = n.next;
            }
            return head;
        }

        public SinglyLinkedListNode<T> GetFirstNode(SinglyLinkedListNode<T> head, int data)
        {
            SinglyLinkedListNode<T> n = head;

            while(n != null)
            {
                if(n.data == data)
                {
                    return n;
                }
                n = n.next;
            }

            return null;
        }

    }
}