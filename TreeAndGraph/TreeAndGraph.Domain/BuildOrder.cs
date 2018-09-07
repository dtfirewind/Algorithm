using System.Collections.Generic;

namespace TreeAndGraph.Domain
{
    public class Project
    {
        private List<Project> children = new List<Project>();
        private Dictionary<string, Project> map = new Dictionary<string, Project>();
        private string name;
        private int dependencies = 0;

        public Project(string name)
        {
            this.name = name;
        }

        public void AddNeighbour(Project node)
        {
            if (!map.ContainsKey(node.GetName()))
            {
                children.Add(node);
                map.Add(node.GetName(), node);
                node.IncrementDependencies();
            }
        }

        public string GetName() { return name; }
        public void IncrementDependencies() { dependencies++; }
        public void DecrementDependencies() { dependencies--; }
        public List<Project> GetChildren() { return children; }
        public int GetNumberDependencies() { return dependencies; }

    }

    public class Graph
    {
        private List<Project> nodes = new List<Project>();
        private Dictionary<string, Project> map = new Dictionary<string, Project>();

        public Project GetOrCreateNode(string name)
        {
            if (!map.ContainsKey(name))
            {
                Project node = new Project(name);
                nodes.Add(node);
                map.Add(name, node);
            }
            if (map.TryGetValue(name, out Project value))
            {
                return value;
            }
            return null;
        }

        public void AddEdge(string startName, string endName)
        {
            Project start = GetOrCreateNode(startName);
            Project end = GetOrCreateNode(endName);
            start.AddNeighbour(end);
        }

        public List<Project> GetNodes() { return nodes; }
    }
    public class BuildOrder
    {
        public Project[] FindBuildOrder(string[] projects, string[][] dependencies)
        {
            Graph graph = BuildGraph(projects, dependencies);
            return OrderProjects(graph.GetNodes());
        }

        public Graph BuildGraph(string[] projects, string[][] dependencies)
        {
            Graph graph = new Graph();
            foreach (string name in projects)
            {
                graph.GetOrCreateNode(name);
            }

            foreach (string[] pair in dependencies)
            {
                string first = pair[0];
                string second = pair[1];
                graph.AddEdge(first, second);
            }

            return graph;
        }

        public Project[] OrderProjects(List<Project> projects)
        {
            Project[] order = new Project[projects.Count];

            int endOfList = AddNonDependent(order, projects, 0);

            int toBeProcessed = 0;
            while (toBeProcessed < order.Length)
            {
                Project current = order[toBeProcessed];

                if(current == null)
                {
                    return null;
                }

                List<Project> children = current.GetChildren();
                foreach (Project child in children)
                {
                    child.DecrementDependencies();
                }

                endOfList = AddNonDependent(order, children, endOfList);
                toBeProcessed++;
            }
            return order;
        }

        public int AddNonDependent(Project[] order, List<Project> projects, int offset)
        {
            foreach (Project project in projects)
            {
                if(project.GetNumberDependencies() == 0)
                {
                    order[offset] = project;
                    offset++;
                }
            }
            return offset;
        }
    }
}