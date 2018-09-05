namespace TreeAndGraph.Domain
{
    public class Node<T>
    {
        public string name;
        public bool visited;
        public int state;
        public Node<T>[] children;
    }
}