using Xunit;
using LinkedList.Domain;

namespace LinkedList.Test
{
    public class PalindromeTest
    {
        Palindrome classP = new Palindrome();

        [Fact]
        public void WhenPalindromeReturnTrue()
        {
        //Given
            SinglyLinkedListNode node = new SinglyLinkedListNode(1);
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(3);
            node.AppendToTail(2);
            node.AppendToTail(1);
        //When
            bool result = classP.IsPalindrome(node);
        //Then
            Assert.True(result);
        }

        [Fact]
        public void WhenNotPalindromeReturnFalse()
        {
        //Given
            SinglyLinkedListNode node = new SinglyLinkedListNode(1);
            node.AppendToTail(2);
            node.AppendToTail(3);
            node.AppendToTail(4);
            node.AppendToTail(4);
            node.AppendToTail(2);
            node.AppendToTail(1);
        //When
            bool result = classP.IsPalindrome(node);
        //Then
            Assert.False(result);
        }
    }
}