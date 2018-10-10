using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        Node left, right;
        int data;
        public Node(int val)
        {
            this.data = val;
        }
        public void Insert(int val)
        {
            if (val <= data)
            {
                if (left == null)
                {
                    left = new Node(val);
                }
                else
                {
                    left.Insert(val);
                }
            }
            else
            {
                if (right == null)
                {
                    right = new Node(val);
                }
                else
                {
                    right.Insert(val);
                }
            }
        }
        public bool Contains(int v)
        {
            if (v == data) return true;
            if (v < data) return left == null ? false : left.Contains(v);
                else return right == null ? false : right.Contains(v);
        }

        public void PrintInOrder()
        {
            if (left != null) left.PrintInOrder(); 
            Console.WriteLine(data);
            if (right != null) right.PrintInOrder();
        }
    }
}
