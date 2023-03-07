using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Day3.Part2
{
    internal class HashTableExample
    {
        private readonly Hashtable hashtable = new();

        public void StoreData(dynamic key, dynamic value)
        {
            hashtable.Add(key, value);
        }

        public void PrintAll()
        {
            foreach (dynamic kvp in hashtable)
            {
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
            }
        }
    }
}
