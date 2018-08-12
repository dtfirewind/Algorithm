using System.Collections.Generic;

namespace LinkedList.Domain
{
    public class RemoveDups
    {
        public void RemoveDuplicates(SinglyLinkedListNode node)
        {
            SinglyLinkedListNode previous = null;
            HashSet<int> set = new HashSet<int>();

            while(node != null)
            {
                if(set.Contains(node.data))
                {
                    previous.next = node.next;
                }else{
                    previous = node;
                    set.Add(node.data);
                }
                node = node.next;
            }
        }

        public void RemoveDuplicatesWithoutBuffer(SinglyLinkedListNode head)
        {
            SinglyLinkedListNode current = head;
            
            while(current != null)
            {
                SinglyLinkedListNode runner = current;
                while(runner.next != null)
                {
                    if(runner.next.data == current.data)
                    {
                        current.next = runner.next.next;
                    }else{
                        runner = runner.next;
                    }
                    
                }
                current = current.next;
            }
        }
        
    }
}