namespace TreeAndGraph.Domain
{
    public class MinimalTree
    {
        
        public TreeNode<int> CreateMinimalTreeBST(int[] array)
        {
            return CreateMinimalTreeBST(array, 0, array.Length - 1);
        }

        public TreeNode<int> CreateMinimalTreeBST(int[] array, int start, int end)
        {
            if(end < start)
            {
                return null;
            }

            int mid = (start + end) / 2;
            TreeNode<int> n = new TreeNode<int>(array[mid]);
            n.left = CreateMinimalTreeBST(array, start, mid - 1);
            n.right = CreateMinimalTreeBST(array, mid + 1, end);
            return n;
        }
    }
}