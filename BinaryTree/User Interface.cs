using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTree
{
    public class User_Interface
    {

        bool again = true;

        public User_Interface(Tree binaryTree)
        {
            ChooseOrderType(binaryTree);
            ChooseAgain(binaryTree);

        }

        public void ChooseOrderType(Tree binaryTree)
        {
            Console.WriteLine("Please Choose how you want your tree arranged: \na) Preorder \nb) Inorder \nc) Postorder");
            string choice = Console.ReadLine().ToLower();

            switch (choice)
                {
                case "a":
                    Console.WriteLine("Preorder Traversal : ");
                    Preorder(binaryTree.ReturnRoot());
                    Console.WriteLine("\n");
                    break;
                case "b":
                    Console.WriteLine("Inorder Traversal : ");
                    Inorder(binaryTree.ReturnRoot());
                    Console.WriteLine("\n");
                    break;
                case "c" :
                    Console.WriteLine("Postorder Traversal : ");
                    Postorder(binaryTree.ReturnRoot());
                    Console.WriteLine("\n");
                    break;
                default:

                    throw new ApplicationException(string.Format("Not a valid choice"));
                }
        }

        public void ChooseAgain(Tree binaryTree)
        {
            while (again)
            {   
                
                Console.WriteLine("\n");
                Console.WriteLine("Would you reorder again? Y or N");
                ConsoleKeyInfo cki = Console.ReadKey();
                again = cki.KeyChar == 'y';
                ChooseOrderType(binaryTree);
                Console.WriteLine("\n");

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
