using System;

namespace HashTableAndBST
{
    //UC1-Finding frequency of words using hash operation
    //UC1-Finding frequency of large paragraph using hash operation
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of Hash Tables and Binary Search Tree");
            //creating object for MyMapnode clas
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(6);
            
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

            Console.ReadLine();
        }
    }
}
