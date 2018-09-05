using System.Collections.Generic;

namespace TreeAndGraph.Domain
{
    public class ListOfDepth
    {
        public List<SinglyLinkedListNode<TreeNode<int>>> CreateLevelLinkedList(TreeNode<int> root)
        {
            List<SinglyLinkedListNode<TreeNode<int>>> lists = new List<SinglyLinkedListNode<TreeNode<int>>>();
            CreateLevelLinkedList(root, lists, 0);
            return lists;
        }

        public void CreateLevelLinkedList(TreeNode<int> root, List<SinglyLinkedListNode<TreeNode<int>>> lists, int level)
        {
            if (root == null) return;

            SinglyLinkedListNode<TreeNode<int>> list = null;
            if(lists.Count == level)
            {
                list = new SinglyLinkedListNode<TreeNode<int>>();
                lists.Add(list);
            }else{
                list = lists[level];
            }
            list.AppendToTail(root.value);
            CreateLevelLinkedList(root.left, lists, level + 1);
            CreateLevelLinkedList(root.right, lists, level + 1);
        }
    }
}