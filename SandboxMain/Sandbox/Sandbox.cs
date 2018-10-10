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
            int[] myArray = new int[] { 3, 2, 4, 1, 5 };
            Node myTree = new Node(myArray[0]);
            for (int x = 1; x < myArray.Length; x++)
            {
                myTree.Insert(myArray[x]);
            }

            bool doesContain = myTree.contains(1);

            myTree.printInOrder();
            Console.ReadLine();    
        }
        
    }
    
    class Node
    {
        public int data;
        public Node next, prev;
        public Node(int v)
        {
            data = v;
        }
    }

    class LinkedList
    {
        Node head;
        public void Append(int v)
        {
            if (head == null)
            {
                head = new Node(v);
                return;
            }
            Node tmpNode = head;
            while (tmpNode.next != null)
            {
                tmpNode = tmpNode.next;
            }
            tmpNode.next = new Node(v);
            tmpNode.next.next = head.prev;
        }

        public void Prepend(int v)
        {
            Node tmpHead = new Node(v);
            tmpHead.next = head;
            head = tmpHead;
            Node c = head;
            while (c.next != null)
            {
                c = c.next;
            }
            head.prev = c.next;
        }

        public void DeleteWithValue(int v)
        {
            if (head == null) return;
            Node c = head;
            while (c.next != null)
            {
                if (c.next.data == v)
                {
                    c.next = c.next.next;
                    return;
                }
                c = c.next;
            }
        }
    }
}
