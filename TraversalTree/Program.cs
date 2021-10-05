using System;

namespace TraversalTree
{
    //In-Order, Pre-Order, Post-Order
    class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public Node() { }
        public Node(int value)
        {
            this.Data = value;
        }
        public void SetValue(int value)
        {
            this.Data = value;
        }
        public void SetRight(Node node)
        {
            Right = node;
        }
        public void SetLeft(Node node)
        {
            Left = node;
        }
    }

    class Program
    {   
        static void InOrder(Node root)
        {
            if (root != null)
            {
                InOrder(root.Left);
                Console.WriteLine(root.Data);
                InOrder(root.Right);
            }
        }

        static void PreOrder(Node root)
        {
            if (root != null)
            {
                Console.WriteLine(root.Data);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
        }

        static void PostOrder(Node root)
        {
            if (root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                Console.WriteLine(root.Data);
            }
        }

        static void Main(string[] args)
        {
            Node a = new Node(4);
            Node b = new Node(2);
            Node c = new Node(5);
            Node d = new Node(1);
            Node e = new Node(3);
            Node f = new Node(6);
            Node g = new Node(7);

            a.SetLeft(b);
            a.SetRight(c);
            b.SetLeft(d);
            b.SetRight(e);
            c.SetLeft(f);
            c.SetRight(g);

            InOrder(a);
            PreOrder(a);
            PostOrder(a);
        }
    }
}
