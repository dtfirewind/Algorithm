namespace TreeAndGraph.Domain
{
    public class ValidateBST
    {
        int index = 0;

        public void CopyBST(TreeNode<int> root, int[] array)
        {
            if(root == null) return;
            CopyBST(root.left, array);
            array[index] = root.value;
            index++;
            CopyBST(root.right, array);
        }

        public bool CheckBST(TreeNode<int> root, Graph<int> graph)
        {
            int[] array = new int[graph.nodes.Length];
            CopyBST(root, array);
            for(int i = 1; i < array.Length; i ++)
            {
                if(array[i] < array[i - 1]) return false;
            }
            return true;
        }
    }
}