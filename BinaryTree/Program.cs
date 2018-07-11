using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class MainClass
    {
        public static void Main(string[] args)
        {   


            Tree binaryTree = new Tree();
            binaryTree.Insert(20);
            binaryTree.Insert(25);
            binaryTree.Insert(45);
            binaryTree.Insert(15);
            binaryTree.Insert(67);
            binaryTree.Insert(43);
            binaryTree.Insert(80);
            binaryTree.Insert(33);
            binaryTree.Insert(67);
            binaryTree.Insert(99);
            binaryTree.Insert(91);

            Console.WriteLine("Inorder Traversal : ");
            binaryTree.Inorder(binaryTree.ReturnRoot());
            Console.WriteLine(" ");
            Console.WriteLine();
        }
    }
}
