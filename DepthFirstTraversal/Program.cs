using System;
using System.Collections.Generic;

namespace DepthFirstTraversal
{

    public class Program
    {
        public class Node
        {
            public int data;
            public Node right;
            public Node left;
        }
        public void DepthFirstSearchTraversalOnTree(Node root)
        {
            Stack<Node> nodes = new Stack<Node>();
            nodes.Push(root);
            while(nodes.Count > 0)
            {
                Node node = nodes.Pop();
                if(node.right != null)
                {
                    nodes.Push(node.right);
                }
                if(node.left != null)
                {
                    nodes.Push(node.left);
                }
                Console.WriteLine(" " + node.data);
            }
        }

        //public HashSet<int> DepthFirstSearchTraversalOnGraph(Node root)
        //{
        //    HashSet<int> visited = new HashSet<int>();
        //    if (!graph.Adjacency.ContainsKey(root))
        //    {
        //        return visited;
        //    }

        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(root.data);

        //    while (stack.Count > 0)
        //    {
        //        int vertex = stack.Pop();
        //        if(visited.Contains(vertex))
        //        {
        //            continue;
        //        }
        //        visited.Add(vertex);
        //        foreach (var neighbor in graph.AdjacencyList[vertex])
        //        {
        //            if (!visited.Contains(neighbor))
        //            {
        //                stack.Push(neighbor);
        //            }
        //        }
        //    }
        //    return visited;
        //}
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
