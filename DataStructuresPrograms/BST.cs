using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPrograms
{
    public class node
    {
        public int Data { get; set; }
        public node Left { get; set; }
        public node Right { get; set; }

        public node()
        {
            this.Left = null;
            this.Right = null;
        }

        public node(int data)
            : base()
        {
            this.Data = data;
        }

    }

    public class BST
    {
        public node _root;
        public BST()
        {
            _root = null;
        }

        public void Insert(int data)
        {
            if (_root == null)
            {
                _root = new node(data);
                return;
            }

            InsertRec(_root, new node(data));
        }

        private void InsertRec(node root,node newNode)
        {
            if (root == null)
            {
                root = newNode;
            }

            if (newNode.Data < root.Data)
            {
                if (root.Left == null)
                    root.Left = newNode;
                else
                    InsertRec(root.Left, newNode);
            }
            else
            {
                if (root.Right == null)
                    root.Right = newNode;
                else
                    InsertRec(root.Right,newNode);
            }
        }

        private void DisplayTree(node root)
        {
            if (root == null) return;

            DisplayTree(root.Left);
            Console.Write(root.Data + "");
            DisplayTree(root.Right);
            
        }

        public void DisplayTree()
        {
            DisplayTree(_root);
            Console.ReadLine();
        }

    }

}
