using System;

namespace TreeAndGraph.Domain
{
    public class CheckBalanced
    {
        public bool IsABalancedTree(TreeNode<int> root)
        {
            if(root == null) return true;

            int heightDiff = GetHeight(root.left) - GetHeight(root.right);

            if(Math.Abs(heightDiff) > 1)
            {
                return false;
            }else{
                return IsABalancedTree(root.left) && IsABalancedTree(root.right);
            }
        }

        public int GetHeight(TreeNode<int> root)
        {
            if(root == null) return - 1;
            return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
        }
    }
}