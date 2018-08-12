using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class RemoveDupsTest
    {
        RemoveDups classRD = new RemoveDups();

        [Fact]
        public void RemoveDuplicateTest()
        {
        //Given
            SinglyLinkedListNode node = new SinglyLinkedListNode(1);
            node.AppendToTail(1);
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(4);
        //When
            classRD.RemoveDuplicates(node);
        //Then
            int[] seq = {1,2,3,4};
            int index = 0;
            
            while(node != null)
            {
                Assert.Equal(seq[index],node.data);
                index++;
                node = node.next;
            }
        }

        [Fact]
        public void RemoveDuplicateWithOutBufferTest()
        {
        //Given
            SinglyLinkedListNode node = new SinglyLinkedListNode(1);
            node.AppendToTail(1);
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(4);
            node.AppendToTail(4);
        //When
            classRD.RemoveDuplicatesWithoutBuffer(node);
        //Then
            int[] seq = {1,2,3,4};
            int index = 0;
            
            while(node != null)
            {
                Assert.Equal(seq[index],node.data);
                index++;
                node = node.next;
            }
        }
    }
}