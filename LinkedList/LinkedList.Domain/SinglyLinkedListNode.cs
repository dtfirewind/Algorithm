namespace LinkedList.Domain
{
    public class SinglyLinkedListNode
    {
        public SinglyLinkedListNode next = null;
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
            SinglyLinkedListNode node = new SinglyLinkedListNode(data);
            SinglyLinkedListNode n = this;

            while(n.next != null)
            {
                n = n.next;
            }
            n.next = node;
        }

        public SinglyLinkedListNode DeleteNode(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode n = head;

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

        public SinglyLinkedListNode GetFirstNode(SinglyLinkedListNode head, int data)
        {
            SinglyLinkedListNode n = head;

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