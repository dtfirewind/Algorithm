namespace LinkedList.Domain
{
    public class KthToLast
    {
        public SinglyLinkedListNode GetKthNode(SinglyLinkedListNode head, int k)
        {
            return CheckQualifyNode(head,k,0);
        }

        public SinglyLinkedListNode CheckQualifyNode(SinglyLinkedListNode node, int k, int index)
        {
            if(node == null)
            {
                return null;
            }

            if(index == k)
            {
                return node;
            }
            else
            {
                return CheckQualifyNode(node.next,k,index+1);
            }
        }
    }
}