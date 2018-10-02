using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
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
                this.data = d;
            }
        }

        public class LinkedList
        {
            Node head;
            public void append(int data)
            {
                if (head == null)
                {
                    head = new Node(data);
                    return;
                }
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = new Node(data);
            }

            public void prepend(int data)
            {
                Node newHead = new Node(data);
                newHead.next = head;
                head = newHead;
            }

            public void deleteWithValue(int data)
            {
                if (head == null) return;
                Node current = head;
                while (current.next != null)
                {
                    if (current.next.data == data)
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
