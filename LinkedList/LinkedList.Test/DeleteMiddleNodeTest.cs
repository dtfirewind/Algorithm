using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class DeleteMiddleNodeTest
    {
        DeleteMiddleNode classDMN = new DeleteMiddleNode();

        [Fact]
        public void TestDeleteMiddleNode()
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
            classDMN.TryDeletingMiddleNode(node.GetFirstNode(node,3));
        //Then
            Assert.Equal(null,node.GetFirstNode(node,3));
        //When
        
        //Then
        }
    }
}