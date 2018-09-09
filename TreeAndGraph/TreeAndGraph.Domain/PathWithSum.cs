using System;

namespace TreeAndGraph.Domain
{
    public class PathWithSum
    {
        public int CountTotalPathWithSum(TreeNode<int> root, int targetSum)
        {
            if(root == null) return 0;

            int pathFromRoot = CountPathsWithSumFromNode(root, targetSum, 0);

            int pathOnLeft = CountTotalPathWithSum(root.left, targetSum);
            int pathOnRight = CountTotalPathWithSum(root.right, targetSum);

            return pathFromRoot + pathOnLeft + pathOnRight;
        }

        public int CountPathsWithSumFromNode(TreeNode<int> node, int targetSum, int currentSum)
        {
            if(node == null) return 0;

            currentSum += node.value;

            int totalPaths = 0;
            if(currentSum == targetSum){
                totalPaths++;
            }

            totalPaths += CountPathsWithSumFromNode(node.left, targetSum, currentSum);
            totalPaths += CountPathsWithSumFromNode(node.right, targetSum, currentSum);
            return totalPaths;
        }
    }
}