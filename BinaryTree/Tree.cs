using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class Tree
    {
        
        public Node root;


        public Tree()
        {
            root = null;

        }

        public Node ReturnRoot()
        {
            return root;
        }

        public void Insert(int toAdd)
        {
            Node newNode = new Node();

            newNode.item = toAdd;
            if (root == null)
                root = newNode;
            
            else
            {
                Node current = root;
                Node parent;

                while (true)
                {
                    parent = current;
                    if (toAdd < current.item)
                    {
                        current = current.left;
                        if (current == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if (current == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
    }
}
