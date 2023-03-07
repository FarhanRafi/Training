using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Part2
{
    internal class List
    {
        private readonly List<string> list = new();

        public void StoreData(string str)
        {
            list.Add(str);
        }
        public void PrintAll()
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
