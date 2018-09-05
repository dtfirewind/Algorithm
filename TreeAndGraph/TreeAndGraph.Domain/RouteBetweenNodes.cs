namespace TreeAndGraph.Domain
{
    public class RouteBetweenNodes
    {
        enum State
        {
            Unvisited = 0,
            Visited = 1,
            Visting = 2
        }

        public bool Search(Graph<int> g, Node<int> start, Node<int> end)
        {
            if (start == end) return true;

            MyQueue<Node<int>> q = new MyQueue<Node<int>>();

            foreach (Node<int> child in g.nodes)
            {
                child.state = (int)State.Unvisited;
            }

            start.state = (int)State.Visting;

            q.Add(start);

            Node<int> u;

            while(!q.IsEmpty())
            {
                u = q.Remove();
                if(u != null)
                {
                    foreach (Node<int> child in u.children)
                    {
                        if (child.state == (int)State.Unvisited)
                        {
                            if(child == end)
                            {
                                return true;
                            }else{
                                child.state = (int)State.Visting;
                                q.Add(child);
                            }
                        }
                    }
                    u.state = (int)State.Visited;
                }
            }
            return false;
        }
    }
}