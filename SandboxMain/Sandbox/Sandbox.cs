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
        Node left, right;
        int data;
        public Node(int data)
        {
            this.data = data;
        }
        public void Insert(int value)
        {
            if (value <= data)
            {
                if (left == null)
                {
                    left = new Node(value);
                } else
                {
                    left.Insert(value);
                }
            } else
            {
                if (right == null)
                {
                    right = new Node(value);
                }
                else
                {
                    right.Insert(value);
                }
            }
        }
        public Boolean contains(int value)
        {
            if (value == data)
            {
                return true;
            }
            else if (value < data)
            {
                if (left == null)
                {
                    return false;
                }
                else
                {
                    return left.contains(value);
                }
            }
            else
            {
                if (right == null)
                {
                    return false;
                }
                else
                {
                    return right.contains(value);
                }
            }
        }

        public void printInOrder()
        {
            if (left != null)
            {
                left.printInOrder();
            }
            Console.WriteLine(data);
            if (right != null)
            {
                right.printInOrder();
            }
        }
    }
}
