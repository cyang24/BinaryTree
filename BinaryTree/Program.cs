﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    class MainClass
    {
        public static void Main(string[] args)
        {   

            Tree binaryTree = new Tree();
            binaryTree.Insert(1);
            binaryTree.Insert(7);
            binaryTree.Insert(84);
            binaryTree.Insert(10);
            binaryTree.Insert(18);
            binaryTree.Insert(87);
            binaryTree.Insert(30);
            binaryTree.Insert(58);
            binaryTree.Insert(73);
            binaryTree.Insert(15);
            binaryTree.Insert(91);
            binaryTree.Insert(240);

            Console.WriteLine("\n");

            User_Interface user_Interface = new User_Interface(binaryTree);

            Console.ReadLine();
        }
    }
}
