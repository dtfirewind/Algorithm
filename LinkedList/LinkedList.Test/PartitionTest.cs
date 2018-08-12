using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class PartitionTest
    {
        Partition classP = new Partition();

        [Fact]
        public void TestPartition()
        {
        //Given
            SinglyLinkedListNode node = new SinglyLinkedListNode(1);
            node.AppendToTail(5);
            node.AppendToTail(2);
            node.AppendToTail(3);
            // node.AppendToTail(2);
            node.AppendToTail(4);
        //When
            SinglyLinkedListNode n =  classP.TryPartition(node,3);
            //Then

            int[] seq = { 2, 1, 5, 3, 4};
            int index = 0;

            while (n != null)
            {
                Assert.Equal(seq[index], n.data);
                index++;
                n = n.next;
            }
        }
    }
}