using System;

namespace HashTableAndBST
{
    //Hash Operation
    //UC1-Finding frequency of words using hash operation
    //UC2-Finding frequency of large paragraph using hash operation
    //UC3-Removing given word from Phrase using hash operation
    //BST operation
    //UC1-Adding new node to the BST
    //UC2-Finding Size of BST
    //UC3-Searching Node in BST

    class Program
    {
        private static bool flag;

        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of Hash Tables and Binary Search Tree");
            //creating object for MyMapnode clas
            /* MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(6);

             myMapNode.Add("1", "Paranoids");
             myMapNode.Add("2", "are");
             myMapNode.Add("3", "not");
             myMapNode.Add("4", "paranoid");
             myMapNode.Add("5", "because");
             myMapNode.Add("6", "they");
             myMapNode.Add("7", "are");
             myMapNode.Add("8", "paranoid");
             myMapNode.Add("9", "but");
             myMapNode.Add("10", "because");
             myMapNode.Add("11", "they");
             myMapNode.Add("12", "keep");
             myMapNode.Add("13", "putting");
             myMapNode.Add("14", "themselves");
             myMapNode.Add("15", "deliberately");
             myMapNode.Add("16", "into ");
             myMapNode.Add("17", "paranoid");
             myMapNode.Add("18", "avoidable");
             myMapNode.Add("19", "situations");
             string key = "18";
             string value = myMapNode.Get(key);
             Console.WriteLine("key {0} holding value {1} ", key, value);
             myMapNode.Remove(key);*/
            //Implementaion of binary search tree
            Console.WriteLine("Welcome to Binary Search Tree");
            BinarySearchTree binarySearch = new BinarySearchTree();
            binarySearch.AddNode(56);
            binarySearch.AddNode(30);
            binarySearch.AddNode(70);
            binarySearch.AddNode(60);
            binarySearch.AddNode(3);
            binarySearch.AddNode(11);
            binarySearch.AddNode(22);
            binarySearch.AddNode(40);
            binarySearch.AddNode(65);
            binarySearch.AddNode(95);
            binarySearch.AddNode(63);
            binarySearch.AddNode(67);
            binarySearch.AddNode(16);
            binarySearch.display(binarySearch.root);
            Console.WriteLine("the number of node in the tree is :{0}", binarySearch.SizeOf(binarySearch.root));
            bool result =binarySearch.findNodeInBST(binarySearch.root, 10);

            if(result==true)
            {
                 Console.WriteLine("Node {0} Present",10);
             }
             else
             {
                 Console.WriteLine("Node not Present");
             }

        }
    }
}

