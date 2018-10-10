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
            Map m = new Map();
            Console.ReadLine();
        }

        class Node
        {
            public Node down, right;
            public string state;
            public Node(string s)
            {
                state = s;
            }
        }

        public class Map
        {
            Node head;
            public Map()
            {
                head = new Node("");
                Node cur = head;
                for (int y = 1; y < 3; y++)
                {
                    cur.down = new Node("");
                    cur = cur.down;
                }
                head.right = new Node("");
                cur = head.right;
                for (int y = 1; y < 3; y++)
                {
                    cur.down = new Node(y == 1 ? "block" : "");
                    cur = cur.down;
                }
                head.right.right = new Node("");
                cur = head.right.right;
                for (int y = 1; y < 3; y++)
                {
                    cur.down = new Node(y == 2 ? "end" : "");
                    cur = cur.down;
                }
            }
        }
    }
    
}
