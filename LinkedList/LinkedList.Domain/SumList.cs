namespace LinkedList.Domain
{
    public class SumList
    {
        public SinglyLinkedListNode GetSum(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            return AddList(node1,node2,0);
        }

        private SinglyLinkedListNode AddList(SinglyLinkedListNode node1, SinglyLinkedListNode node2, int carry)
        {
            SinglyLinkedListNode result = new SinglyLinkedListNode();

            if(node1 == null && node2 == null && carry == 0)
            {
                return null;
            }

            int value = carry;
            if(node1 != null){
                value += node1.data;
            }
            if(node2 != null){
                value += node2.data;
            }
            result.data = value % 10;

            if(node1 != null || node2 != null){
                SinglyLinkedListNode more = AddList(node1 == null ? null : node1.next,
                                node2 == null ? null : node2.next,
                                value >= 10 ? 1 : 0);
                if(more != null)
                {
                    result.AppendToTail(more.data);
                }               
            }

            return result;
        }
    }
}