using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BinaryTrees
    {
        Node root;
        public BinaryTrees()
        {
            root = null;
        }
        public void Insert(int x)
        {
            if (root == null) root = new Node(x);
            else Insert(root, x);
        }
        private void Insert(Node n, int x)
        {
            if(x < n.getData())
            {
                if (n.getLeft() == null) n.setLeft(x);
                else Insert(n.getLeft(), x);
            }
            else if (x >= n.getData())
            {
                if (n.getRight() == null) n.setRight(x);
                else Insert(n.getRight(), x);
            }
        }
        public Node Search(int x)
        {
            if (root.getData() == x) return root;
            else return Search(root, x);
        }
        private Node Search(Node n, int x)
        {
            if (n.getData() == x) return n;
            else if (x < n.getData())
            {
                if (n.getLeft() == null) return null;
                else return Search(n.getLeft(), x);
            }
            else if (x > n.getData())
            {
                if (n.getRight() == null) return null;
                else return Search(n.getRight(), x);
            }
            else return null;    
        }
    }
}
