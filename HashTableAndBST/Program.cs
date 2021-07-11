using System;

namespace HashTableAndBST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementaion of Hash Tables and Binary Search Tree");
            //creating object for MyMapnode clas
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(6);
            myMapNode.Add("1", "To");
            myMapNode.Add("2", "be");
            myMapNode.Add("3", "or");
            myMapNode.Add("4", "not");
            myMapNode.Add("5", "to");
            myMapNode.Add("6", "be");
            string key = "5";
            string value = myMapNode.Get(key);
            Console.WriteLine("key {0} holding value {1} ", key, value);
            Console.ReadLine();
        }
    }
}
