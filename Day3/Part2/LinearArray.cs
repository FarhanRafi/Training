using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Part2
{
    internal class LinearArray
    {
        int[] numbers;

        public void InitArray(int size)
        {
            numbers = new int[size];
        }

        public int ArrayLength()
        {
            return numbers.Length;
        }

        public void StoreData(int index, int data) 
        {
            numbers[index] = data;
        }
        public void PrintAll() 
        {
            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
