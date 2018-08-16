using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class IntersectionTest
    {
        Intersection classI = new Intersection();

        [Fact]
        public void WhenEmtptyReturnNull()
        {
        //Given
            SinglyLinkedListNode node1 = null;
            SinglyLinkedListNode node2 = new SinglyLinkedListNode();
        //When
            SinglyLinkedListNode result = classI.GetIntersection(node1, node2);
        //Then
            Assert.True(AreSame(null,result));
        }

        [Fact]
        public void WhenIntersectReturnNode()
        {
        //Given
            SinglyLinkedListNode node1 = new SinglyLinkedListNode(7);
            SinglyLinkedListNode node2 = new SinglyLinkedListNode(12);

            node1.AppendToTail(6);
            node1.AppendToTail(5);
            node1.AppendToTail(4);
            node1.AppendToTail(3);
            node1.AppendToTail(2);
            node1.AppendToTail(1);

            SinglyLinkedListNode intersection = node1.GetFirstNode(node1,4);

            node2.AppendToTail(11);
            
            SinglyLinkedListNode nodeTail = node2.GetFirstNode(node2, 11);

            nodeTail.next = intersection;

        //When
            SinglyLinkedListNode result = classI.GetIntersection(node1, node2);
        //Then
            Assert.True(AreSame(intersection,result));
        }

        [Fact]
        public void WhenNotIntersectReturnNull()
        {
        //Given
            SinglyLinkedListNode node1 = new SinglyLinkedListNode(7);
            SinglyLinkedListNode node2 = new SinglyLinkedListNode(12);

            node1.AppendToTail(6);
            node1.AppendToTail(5);
            node1.AppendToTail(4);
            node2.AppendToTail(6);
            node2.AppendToTail(5);
            node2.AppendToTail(4);
        //When
            SinglyLinkedListNode result = classI.GetIntersection(node1, node2);
        //Then
            Assert.True(AreSame(null,result));
        }

        private static bool AreSame(SinglyLinkedListNode node1, SinglyLinkedListNode node2)
        {
            return node1 == node2;
        }
    }
}
