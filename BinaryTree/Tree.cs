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

        public void Insert(int id)
        {
            Node newNode = new Node();

            newNode.item = id;
            if (root == null)
                root = newNode;
            
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
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

        public bool Contains(T data)
        {
            // search the tree for a node that contains data
            Tree tree = Node root;
            int result;
            while (tree != null)
            {
                result = comparer.Compare(current.Value, data);
                if (result == 0)
                    // we found data
                    return true;
                else if (result > 0)
                    // current.Value > data, search current's left subtree
                    current = current.Left;
                else if (result < 0)
                    // current.Value < data, search current's right subtree
                    current = current.Right;
            }

            return false;       // didn't find data
        }

    }
}
