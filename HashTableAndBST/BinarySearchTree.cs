using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    //create the class for storing the value in the node 
    public class TreeNode
    {
        public int value;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode(int value)
        {
            this.value = value;
            this.Left = null;
            this.Right = null;
        }
    }
  

    //create the binary search tree class that extends IComparable for comparision
    class BinarySearchTree//<T> where T : IComparable

    {
        public static bool flag = false;
        public TreeNode root;

        //create the add node method
        public void AddNode(int value)
        {
            TreeNode newNode = new TreeNode(value);
            //if the new node is the first node then point root tothe current node
            if (root == null)
            {
                root = newNode;
            }
            //else check for greater or lesser condition
            else
            {
                TreeNode parent = root;
                TreeNode current = root;
                //continue the below process till the target position  is achieved
                while (true)
                {
                    parent = current;
                    //if the current node value is greater than new node then iterate to left till null
                    if (current.value.CompareTo(value) >= 0)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    //if the current node value is less than new node then iterate to right till null
                    else
                    {
                        current = current.Right;
                        if (current == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public int SizeOf(TreeNode parent)
        {
            //if the root is null then tree is empty
            if (parent == null)
            {
                return 0;
            }
            //else find size of left sub tree and size of right sub tree then add together with one root node
            else
            {
                return (SizeOf(parent.Left) + 1 + SizeOf(parent.Right));
            }
        }
        public  bool findNodeInBST(TreeNode node, int value)
        {
            if (null == node)
            {
                return false;
            }
            //Condition 1. we found the value
            if (node.value == value)
            {
                return true;
            }
            //Condition 2. 
            //Value is less than node value. so go left sub tree
            else if (value < node.value)
                return findNodeInBST(node.Left, value);
            //Condition 3. 
            //Value is greater than node value. so go right sub tree
            else
                return findNodeInBST(node.Right, value);
        }


        public void display(TreeNode parent)
        {
            if (parent != null)
            {
                display(parent.Left);
                Console.WriteLine("The node :{0}", parent.value);
                display(parent.Right);
            }
        }
    }
}
