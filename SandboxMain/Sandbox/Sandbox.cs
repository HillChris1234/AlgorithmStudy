using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph.Node n1 = new Graph.Node(1);
            Graph.Node n2 = new Graph.Node(2);
            Graph.Node n3 = new Graph.Node(3);
            Graph.Node n4 = new Graph.Node(4);
            Graph.Node n5 = new Graph.Node(5);
            Graph.Node n6 = new Graph.Node(6);
            n1.adjacent.AddLast(n2);
            n1.adjacent.AddLast(n3);
            n2.adjacent.AddLast(n4);
            n2.adjacent.AddLast(n5);
            n2.adjacent.AddLast(n6);
            Graph.
            Console.ReadLine();
        }

        public class Employee
        {
            public string name;
            public List<Employee> Employees;
            public Employee(string name)
            {
                this.name = name;
            }
            public void isEmployeeOf(Employee e)
            {
                this.Employees.Add(e);
            }
        }




        public class Graph
        {
            private Dictionary<int, Node> nodeLookUp = new Dictionary<int, Node>();
            public class Node
            {
                public int id;
                public LinkedList<Node> adjacent = new LinkedList<Node>();
                public Node (int id)
                {
                    this.id = id;
                }
            }
            public Node getNode(int id)
            {
                return nodeLookUp[id];
            }

            public void addEdge(int source, int destination)
            {
                Node s = getNode(source);
                Node d = getNode(destination);
                s.adjacent.AddLast(d);
            }

            public bool hasPathDFS(int source, int destination)
            {
                Node s = getNode(source);
                Node d = getNode(destination);
                List<int> visited = new List<int>();
                return hasPathDFS(s, d, visited);
            }

            private bool hasPathDFS(Node source, Node destination, List<int> visited)
            {
                if (visited.Contains(source.id)) return false;
                visited.Add(source.id);
                if (source == destination)
                {
                    return true;
                }
                foreach (Node child in source.adjacent)
                {
                    if (hasPathDFS(child, destination, visited))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
    }
    
}
