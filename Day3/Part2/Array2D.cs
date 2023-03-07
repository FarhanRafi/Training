using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3.Part2
{
    internal class Array2D
    {
        int[ , ] array;

        public void InitArray(int row, int column)
        {
            array = new int[row, column];
        }

        public int ArrayLength()
        {
            return array.Length;
        }

        public void StoreData(int row, int column, int data)
        {
            array[row, column] = data;
        }

        public void PrintAll()
        {
            Console.WriteLine(string.Join(" ", array.Cast<int>()));
        }
    }
}
