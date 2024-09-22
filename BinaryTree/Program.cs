// See https://aka.ms/new-console-template for more information
using BinaryTree;
using Microsoft.VisualBasic.FileIO;

BinaryTrees tree = new BinaryTrees();
tree.Insert(3);
tree.Insert(4);
tree.Insert(5);
tree.Insert(8);
tree.Insert(10);
Node n = tree.Search(8);
if (n != null) Console.WriteLine("Binary Tree success");
else Console.WriteLine("Binary Tree failure");
Node k = tree.Delete(n, 8);
if (k != null) Console.WriteLine("Binary Tree success");