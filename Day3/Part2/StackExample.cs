using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Part2
{
    internal class StackExample
    {
        private readonly Stack<int> stack = new();

        public void StoreData(int number)
        {
            stack.Push(number);
        }
        
        public int GetData()
        {
            return stack.Peek();
        }

        public void PrintAll()
        {
            foreach (var item in stack) 
            {
                Console.WriteLine(item);
            }
        }
    }
}
