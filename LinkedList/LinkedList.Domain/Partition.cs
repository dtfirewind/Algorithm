namespace LinkedList.Domain
{
    public class Partition
    {
        public SinglyLinkedListNode TryPartition(SinglyLinkedListNode node, int x)
        {
            SinglyLinkedListNode head = node;
            SinglyLinkedListNode tail = node;
            while (node != null)
            {
                SinglyLinkedListNode next = node.next;
                if (node.data < x)
                {
                    /* Ins ert node at head. */
                    node.next = head;
                    head = node;
                }
                else
                {
                    tail.next = node;
                    tail = node;
                }
                node = next;
            }
            tail.next = null;

            return head;
        }
    }
}