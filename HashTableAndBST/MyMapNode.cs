using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST
{
    public class MyMapNode<K, V>
    {
        // structure to create Key Value pair
        public struct KeyValue<K, V>
        {
            public K Key { get; set; }
            public V Value { get; set; }

        }
        private readonly int size;
        private readonly LinkedList<KeyValue<K, V>>[] items;

        public MyMapNode(int size)
        {
            this.size = size;
            this.items = new LinkedList<KeyValue<K, V>>[size];
        }
        //method to get array position for key
        protected int GetArrayPosition(K Key)
        {
            int hash = Key.GetHashCode();
            int position = hash % size;
            return Math.Abs(position);

        }
        //Get methd returns the value corresponding to the key if value is present in hash table
        public V Get(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                    return item.Value;
            }
            return default(V);

        }
        //Method to add new Key value pair to the hash table
        public void Add(K key, V value)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            KeyValue<K, V> item = new KeyValue<K, V>() { Key = key, Value = value };
            linkedList.AddLast(item);
            Console.WriteLine(item.Key + " " + item.Value);
        }
        //Method to remove new Key value pair to the hash table
        public void Remove(K key)
        {
            int position = GetArrayPosition(key);
            LinkedList<KeyValue<K, V>> linkedList = GetLinkedList(position);
            bool itemfound = false;
            KeyValue<K, V> founditem = default(KeyValue<K, V>);
            foreach (KeyValue<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemfound = true;
                    founditem = item;
                }


            }
            if (itemfound)
            {
                linkedList.Remove(founditem);
                Console.WriteLine("Removed Successfully with key " + founditem.Key);
            }
        }


        //Method to get linked list for the hash value
        protected LinkedList<KeyValue<K, V>> GetLinkedList(int position)
        {
            LinkedList<KeyValue<K, V>> linkedList = items[position];
            if (linkedList == null)
            {
                linkedList = new LinkedList<KeyValue<K, V>>();
                items[position] = linkedList;
            }
            return linkedList;
        }
        /*public void Display()
              {
                  foreach(var linkedlist in items)
                  {
                      if(linkedlist!=null)
                      {
                          foreach (var element in linkedlist) ;
                          string result = element.ToString();


                      }
                  }
              }*/
    }
}
