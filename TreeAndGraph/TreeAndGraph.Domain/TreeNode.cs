namespace TreeAndGraph.Domain
{
    public class TreeNode<T>
    {
        public int value;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode()
        {

        }
        public TreeNode(int value)
        {
            this.value = value;
        }
    }
}