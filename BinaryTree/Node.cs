using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class Node
    {
        private int n;
        private Node left;
        private Node right;
        public Node(int data)
        {
            n = data;
            left = null;
            right = null;
        }
        public int getData()
        {
            return n;
        }
        public Node getRight()
        {
            return right;
        }
        public Node getLeft()
        {
            return left;
        }
        public void setLeft(int x)
        {
            left = new Node(x);
        }
        public void setRight(int x)
        {
            right = new Node(x);
        }
        public void setLeft(Node n)
        {
            left = n;
        }
        public void setRight(Node n)
        {
            right = n;
        }
    }
}
