using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class SumListTest
    {
        SumList classSL = new SumList();

        [Fact]
        public void TestSumList()
        {
        //Given
        SinglyLinkedListNode node1 = new SinglyLinkedListNode(1);
            node1.AppendToTail(5);
            node1.AppendToTail(3);
        
        SinglyLinkedListNode node2 = new SinglyLinkedListNode(5);
            node2.AppendToTail(7);
            node2.AppendToTail(9);

        SinglyLinkedListNode expected = new SinglyLinkedListNode(6);
            expected.AppendToTail(2);
            expected.AppendToTail(3);
            expected.AppendToTail(1);
        //When
            SinglyLinkedListNode result = classSL.GetSum(node1,node2);
        //Then
            while (result != null)
            {
                Assert.Equal(expected.data, result.data);
                result = result.next;
                expected = expected.next;
            }
        }
    }
}