using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class KthToLastTest
    {
        KthToLast classKTL = new KthToLast();

        SinglyLinkedListNode node = new SinglyLinkedListNode(1);
            

        void InitList()
        {
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(5);
            node.AppendToTail(6);
            node.AppendToTail(7);
        }

        [Fact]
        public void KthTest()
        {
        //Given
            InitList();
            int k = 0;
        //When
            SinglyLinkedListNode n = classKTL.GetKthNode(node,k);

        //Then
            Assert.Equal(1,n.data);
        }
    }
}