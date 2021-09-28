using System;
using System.Collections.Generic;

namespace DepthFirstTraversal
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Node a = new Node(1);
            Node b = new Node(2);
            Node c = new Node(3);
            Node d = new Node(4);
            Node e = new Node(5);
            Node f = new Node(6);
            Node g = new Node(7);

            a.SetLeft(b);
            a.SetRight(c);
            b.SetLeft(d);
            c.SetLeft(e);
            e.SetLeft(f);
            e.SetRight(g);

            DepthFirstSearchTraversalOnTree(e);
        }
        public class Node
        {
            public int data;
            public Node right;
            public Node left;

            public Node(int value)
            {
                this.data = value;
            }
            public void SetValue(int value)
            {
                this.data = value;
            }
            public void SetRight(Node node)
            {
                right = node;
            }
            public void SetLeft(Node node)
            {
                left = node;
            }
        }
        static void DepthFirstSearchTraversalOnTree(Node root)
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

    }
}
