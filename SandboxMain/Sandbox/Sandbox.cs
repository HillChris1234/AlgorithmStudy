using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    public class Program
    {
        static Node sample_tree()
        {
            Node root = 
                new Node("A",
                    new Node("B",
                        new Node("C"), new Node("D")),
                    new Node("E",
                        new Node("F"), new Node("G",
                                                new Node("H"), null)));
            return root;
        }
        public static void Main(string[] args)
        {
            Node tree = sample_tree();
            Console.WriteLine("BFS --> "); bfs_traversal(tree);
        }

        static void bfs_traversal(Node node)
        {
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(node);
            while (q.Count > 0)
            {
                node = q.Dequeue();
                Console.Write(node.data + " ");
                
                if (node.left != null)
                    q.Enqueue(node.left);
                if (node.right != null)
                    q.Enqueue(node.right);
            }
        }
    }

    public class Node
    {
        public string data;
        public List<Node> nodes;
        public Node(string data, List<Node> nodes)
        {
            this.data = data;
            foreach(Node n in nodes)
            {
                this.nodes.Add(n);
            }
        }
        public Node(string data)
        {
            this.data = data;
            this.nodes = null;
        }
    }

    public class NodeBinary
    {
        public Node left;
        public Node right;
        public string data;
        public NodeBinary(string data, Node left, Node right)
        {
            this.data = data;
            this.left = left;
            this.right = right;
        }

        public NodeBinary(string data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    }
}
