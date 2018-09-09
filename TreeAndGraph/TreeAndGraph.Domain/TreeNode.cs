namespace TreeAndGraph.Domain
{
    public class TreeNode<T>
    {
        public int value;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode<T> parent;
        public int size;
        public TreeNode()
        {

        }
        public TreeNode(int value)
        {
            this.value = value;
            size = 1;
        }

        public virtual TreeNode<T> GetRandomNode()
        {
            return null;
        }

        public virtual void InsertInOrder(int d)
        {

        }

        public virtual TreeNode<T> Find(int d)
        {
            return null;
        }
    }
}