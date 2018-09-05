namespace TreeAndGraph.Domain
{
    public class Graph<T>
    {
        public Node<T>[] nodes;

        public Node<T> GetNode()
        {
            return new Node<T>();
        }

        public Node<T> DFSGetNode(Node<T> root, Node<T> target)
        {
            if(root == null) return null;
            if(root == target) return root;
            root.visited = true;
            foreach (Node<T> child in root.children)
            {
                if(!child.visited)
                {
                    return DFSGetNode(child,target);
                }
            }
            return null;
        }

        public Node<T> BFSGetNode(Node<T> root, Node<T> target)
        {
            MyQueue<Node<T>> queue = new MyQueue<Node<T>>();

            root.visited = true;
            queue.Add(root);

            while(!queue.IsEmpty())
            {
                Node<T> r = queue.Remove();
                if(r == target) return r;
                foreach (Node<T> child in r.children)
                {
                    if(!child.visited)
                    {
                        child.visited = true;
                        queue.Add(child);
                    }
                }
            }

            return null;
        }
    }
}