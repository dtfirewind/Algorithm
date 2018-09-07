using System;

namespace TreeAndGraph.Domain
{
    public class CommonAncestor
    {
        public TreeNode<int> GetCommonAncestor(TreeNode<int> p, TreeNode<int> q)
        {
            int pDepth = Depth(p);
            int qDepth = Depth(q);

            int delta = pDepth - qDepth;

            TreeNode<int> first = delta > 0 ? q : p;
            TreeNode<int> second = delta > 0 ? p : q;

            second = GoUpBy(second, Math.Abs(delta));

            while(first != second && first != null && second != null)
            {
                first = first.parent;
                second = second.parent;
            }

            return first == null || second == null ? null : first;

        }

        public TreeNode<int> GoUpBy(TreeNode<int> node, int delta)
        {
            while(delta > 0 && node != null)
            {
                node = node.parent;
                delta--;
            }
            return node;
        }

        public int Depth(TreeNode<int> node)
        {
            int depth = 0;
            while(node != null)
            {
                node = node.parent;
                depth++;
            }
            return depth;
        }

        public TreeNode<int> GetCommonAncestor(TreeNode<int> root, TreeNode<int> p, TreeNode<int> q)
        {
            if(!Covers(root, q) || !Covers(root, p))
            {
                return null;
            }

            return AncestorHelper(root, p, q);
        }

        public TreeNode<int> AncestorHelper(TreeNode<int> root, TreeNode<int> p, TreeNode<int> q)
        {
            if(root == null || p == null || q == null)
            {
                return null;
            }

            bool pIsOnLeft = Covers(root.left, p);
            bool qIsOnRight = Covers(root.right, q);

            if(pIsOnLeft != qIsOnRight){
                return root;
            }

            TreeNode<int> childSide = pIsOnLeft ? root.left : root.right;

            return AncestorHelper(childSide, p, q);
        }

        public bool Covers(TreeNode<int> root, TreeNode<int> node)
        {
            if(root == null) return false;
            if(root == node) return true;
            return Covers(root.left, node) || Covers(root.right, node);
        }
    }
}