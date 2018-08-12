namespace LinkedList.Domain
{
    public class DeleteMiddleNode
    {
        public bool TryDeletingMiddleNode(SinglyLinkedListNode node)
        {
            if(node == null || node.next == null)
            {
                return false;
            }

            SinglyLinkedListNode next = node.next;
            node.next = next.next;
            node.data = next.data;
            return true;
        }
    }
}