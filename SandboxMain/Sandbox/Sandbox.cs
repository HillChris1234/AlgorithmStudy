using System;
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
            Console.ReadLine();
        }
        
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {

            }
        }
        
        public class LinkedList
        {
            Node head;
            public void append(int d)
            {
                if (head == null)
                {
                    head = new Node(d);
                    return;
                }
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(d);
            }

            public void prepend(int d)
            {
                Node newHead = new Node(d);
                newHead.next = head;
                head = newHead;
            }

            public void delete(int d)
            {
                if (head == null) return;
                Node current = head;
                while (current.next != null)
                {
                    if (current.next.data == d)
                    {
                        current.next = current.next.next;
                        return;
                    }
                    current = current.next;
                }
            }
        }
    }
}
