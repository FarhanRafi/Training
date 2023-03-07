using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Part2
{
    internal class HashSetExample
    {
        HashSet<string> strings = new();

        public void StoreData(string str)
        {
            strings.Add(str);
        }

        public void PrintAll()
        {
            foreach (var str in  strings)
            {
                Console.WriteLine(str);
            }
        }
    }
}
