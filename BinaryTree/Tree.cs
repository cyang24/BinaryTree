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


        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                Preorder(Root.left);
                Preorder(Root.right);
            }
        }

        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.left);
                Console.Write(Root.item + " ");
                Inorder(Root.right);
            }
        }

        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.left);
                Postorder(Root.right);
                Console.Write(Root.item + " ");
            }
        }
    }
}
