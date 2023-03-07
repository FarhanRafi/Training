using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Part1
    {
        public static int No9(string str, char ch)
        {
            int count = 0;
            foreach (var character in str)
            {
                if (character == ch)
                {
                    count++;
                }
            }

            return count;
        }

        public static string No10(Dictionary<string, string> obj, string str) 
        {
            if (obj.ContainsKey(str)) return obj[str];
            else return String.Empty;
        }

        // No 11, No 12 is similar to 2 & 1
    }
}
