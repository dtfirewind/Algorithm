using System.Collections.Generic;

 namespace TreeAndGraph.Domain
 {
      public class BSTSequence
      {
          public List<SinglyLinkedListNode<int>> GetBSTSequence(TreeNode<int> root)
          {
              List<SinglyLinkedListNode<int>> result = new List<SinglyLinkedListNode<int>>();

              if(root == null)
              {
                  result.Add(new SinglyLinkedListNode<int>());
                  return result;
              }

              SinglyLinkedListNode<int> prefix = new SinglyLinkedListNode<int>();
              prefix.AppendToTail(root.value);

              List<SinglyLinkedListNode<int>> leftSeq = GetBSTSequence(root.left);
              List<SinglyLinkedListNode<int>> rightSeq = GetBSTSequence(root.right);

              foreach (SinglyLinkedListNode<int> left in leftSeq)
              {
                  foreach (SinglyLinkedListNode<int> right in rightSeq)
                  {
                      List<SinglyLinkedListNode<int>> weaved = new List<SinglyLinkedListNode<int>>();

                      WeaveLists(left, right, weaved, prefix);

                      result.AddRange(weaved);
                  }
              }

              return result;
          }

          public void WeaveLists(SinglyLinkedListNode<int> first, SinglyLinkedListNode<int> second, List<SinglyLinkedListNode<int>> weaved, SinglyLinkedListNode<int> prefix)
          {
              if(first == null || second == null)
              {
                  SinglyLinkedListNode<int> result = prefix;
                  while(first != null){
                      result.AppendToTail(first.data);
                      first = first.next;
                  }
                  while(second != null){
                      result.AppendToTail(second.data);
                      second = second.next;
                  }
                  weaved.Add(result);               
              }

              int headFirst = first.GetFirstNode(first, first.data).data;
              first.DeleteNode(first, first.data);
              prefix.AppendToTail(headFirst);
              WeaveLists(first, second, weaved, prefix);
              prefix.DeleteNode(prefix, headFirst);
              first.AppendToTail(headFirst);
              
              int headSecond = second.GetFirstNode(second, second.data).data;
              second.DeleteNode(second, second.data);
              prefix.AppendToTail(headSecond);
              WeaveLists(first, second, weaved, prefix);
              prefix.DeleteNode(prefix, headSecond);
              second.AppendToTail(headSecond);

          }
      }
 }