using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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
        public Node Delete(Node n, int x)
        {
            if (n == null) return n;
            else
            {
                if(x < n.getData())
                {
                    return Delete(n.getLeft(), x);
                }
                else if (x > n.getData())
                {
                    return Delete(n.getRight(), x);
                }
                else //if x is found in the node
                {
                    if (n.getLeft() == null) return n.getRight(); //if there is no left node, node is replaced with the right child
                    else if (n.getRight() == null) return n.getLeft(); //vice versa
                    else //if there are two child nodes
                    {
                        Node succ = getSuccess(n);
                        n.setData(succ.getData());
                        n.setRight(Delete(n.getRight(), x));
                    }
                }
            }
            return n;
        }
        //Not 100% sure why these are needed
        public static Node getSuccess(Node n)
        {
            n = n.getRight();
            while (n != null && n.getLeft() != null)
            {
                n = n.getLeft();
            }
            return n;
        }
        public static void inOrder(Node n)
        {
            if (n != null)
            {
                inOrder(n.getLeft());
                inOrder(n.getRight());
            }
        }
    }
}
