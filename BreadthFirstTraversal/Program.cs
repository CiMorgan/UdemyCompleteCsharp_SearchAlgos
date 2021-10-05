using System;
using System.Collections.Generic;

namespace BreadthFirstTraversal
{
    public class Node
    {
        public int data;
        public Node right;
        public Node left;
        public List<object> Neighbors { get; set; }

        public Node() { }
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
    public class Program
    {
        static void BreadthFirstTraversalOnTree(Node root)
        {
            Queue<Node> nodes = new Queue<Node>();
            if (root == null)
            {
                return;
            }
            nodes.Enqueue(root);
            while (nodes.Count > 0)
            {
                Node node = nodes.Dequeue();
                Console.WriteLine(" " + node.data);
                if (node.left != null)
                {
                    nodes.Enqueue(node.left);
                }
                if (node.right!= null)
                {
                    nodes.Enqueue(node.right);
                }
            }
        }
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

            BreadthFirstTraversalOnTree(c);

            //Node one = new Node(1);
            //Node two = new Node(2);
            //Node three = new Node(3);
            //Node four = new Node(4);
            //Node five = new Node(5);
            //Node six = new Node(6);

            //Graph graph = new Graph(6);
            //graph.AddEdge(six, four);
            //graph.AddEdge(four, five);
            //graph.AddEdge(four, three);
            //graph.AddEdge(three, two);
            //graph.AddEdge(five, two);
            //graph.AddEdge(two, one);
            //graph.AddEdge(five, one);

        }
    }
}
