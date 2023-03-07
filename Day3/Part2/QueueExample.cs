using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Part2
{
    internal class QueueExample
    {
        private readonly Queue<string> queue = new();

        public void StoreData(string number)
        {
            queue.Enqueue(number);
        }

        public string GetData()
        {
            return queue.Peek().ToString();
        }

        public void PrintAll()
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

        }
    }
}
