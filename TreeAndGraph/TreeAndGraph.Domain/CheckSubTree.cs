namespace TreeAndGraph.Domain
{
    public class CheckSubTree
    {
        public bool IsSubTree(TreeNode<int> t1, TreeNode<int> t2)
        {
            if(t2 == null) return false;
            return CheckIt(t1, t2);
        }

        public bool CheckIt(TreeNode<int> t1, TreeNode<int> t2)
        {
            if(t1 == null){
                return false;
            }else if(t1.value == t2.value && MatchTree(t1, t2)){
                return true;
            }
            return CheckIt(t1.left, t2) || CheckIt(t1.right, t2);
        }

        public bool MatchTree(TreeNode<int> t1, TreeNode<int> t2)
        {
            if(t1 == null && t2 == null){
                return true;
            } else if(t1 == null || t2 == null){
                return false;
            } else if(t1.value != t2.value){
                return false;
            } else{
                return MatchTree(t1.left, t2.left) && MatchTree(t1.right, t2.right);
            }
        }
    }
}