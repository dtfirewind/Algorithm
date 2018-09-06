namespace TreeAndGraph.Domain
{
    public class Successor
    {
        public TreeNode<int> FindSuccessor(TreeNode<int> root)
        {
            if(root == null) return null;

            if(root.right != null) 
            {
                TreeNode<int> n = root;
                while(root.left != null)
                {
                    n = n.left;
                }
                return n;
            }else
            {
                TreeNode<int> q = root;
                TreeNode<int> x = q.parent;
                while(x != null && x.left != q)
                {
                    q = x;
                    x = x.parent;
                }
                return x;
            }
        }
    }
}