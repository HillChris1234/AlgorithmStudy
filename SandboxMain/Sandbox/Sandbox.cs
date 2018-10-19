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
        public static void Main(string[] args)
        {
            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node e = new Node("E");
            Node f = new Node("F");
            Node g = new Node("G");
            a.nodes.Add(b);
            a.nodes.Add(c);
            c.nodes.Add(d);
            c.nodes.Add(e);
            c.nodes.Add(f);
            f.nodes.Add(g);

            Console.WriteLine("BFS --> "); nodeconnect(a, g);
        }

        static bool nodeconnect(Node s, Node d)
        {
            if (s == d) return true;
            Queue<Node> q = new Queue<Node>();
            List<Node> v = new List<Node>();
            q.Enqueue(s);
            while (q.Count > 0)
            {
                s = q.Dequeue();
                if (s == d) return true;
                foreach (Node n in s.nodes)
                {
                    if (!v.Contains(n))
                    {
                        if (n == d)
                        {
                            return true;
                        }
                        else
                        {
                            v.Add(n);
                            q.Enqueue(n);
                        }
                    }
                }
            }
            return false;
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
            this.nodes = new List<Node>();
        }
    }
}
