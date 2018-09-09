using System;

namespace TreeAndGraph.Domain
{
    public class TreeNodeWithRandomNode<T> : TreeNode<T>
    {
        public override TreeNode<T> GetRandomNode()
        {
            int leftSize = left == null ? 0 : left.size;
            Random random = new Random();
            int index = random.Next(size);
            if(index < leftSize){
                return left.GetRandomNode();
            }else if (index == leftSize){
                return this;
            }else {
                return right.GetRandomNode();
            }
        }

        public override void InsertInOrder(int d)
        {
            if( d < value){
                if (left == null)
                {
                    left = new TreeNode<T>(d);
                } else {
                    left.InsertInOrder(d);
                }
            } else{
                if(right == null)
                {
                    right = new TreeNode<T>(d);
                }else {
                    right.InsertInOrder(d);
                }
            }
            size++;
        }

        public override TreeNode<T> Find(int d)
        {
            if(d == value){
                return this;
            }else if (d <= value)
            {
                return left != null ? left.Find(d) : null;
            }else if (d > value)
            {
                return right != null ? right.Find(d) : null;
            }
            return null;
        }
    }
}