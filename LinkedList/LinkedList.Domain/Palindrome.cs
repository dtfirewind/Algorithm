using System.Collections.Generic;

namespace LinkedList.Domain
{
    public class Palindrome
    {
        public bool IsPalindrome(SinglyLinkedListNode node)
        {
            
            SinglyLinkedListNode slow = node, fast = node;
            Stack<int> stack = new Stack<int>();

            while(fast != null && fast.next != null)
            {
                stack.Push(slow.data);
                slow = slow.next;
                fast = fast.next.next;
            }

            if(fast != null){
                slow = slow.next;
            }

            while(slow != null)
            {
                int stored = stack.Pop();
                if(stored != slow.data){
                    return false;
                }
                slow = slow.next;
            }
            return true;
        }
    }
}