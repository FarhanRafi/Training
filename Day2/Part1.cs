using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    public class Part1
    {
        public static List<string> No1(int[] ints, int number)
        {
            var list = new List<string>();
            for (int i = 0; i < ints.Length; i++)
            {
                for (int j = 0; j < ints.Length; j++)
                {
                    if (ints[i] + ints[j] == number)
                    {
                        list.Add($"{ints[i]} {ints[j]}");
                    }
                }
            }

            return list;
        }

        public static string No2(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }

            return $"Max: {max}& Min: {min}";
        }

        public static string No4(string str)
        {
            int vowelCount = 0;
            int consonantCount = 0;
            str = str.Trim().ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                if ("aeiou".Contains(str[i]))
                {
                    vowelCount++;
                }
                else
                {
                    consonantCount++;
                }
            }
            return $"Vowels: {vowelCount} & Constants: {consonantCount}";
        }

        public static string No5(Dictionary<string, string> obj, string str)
        {
            var key = obj.FirstOrDefault(x => x.Value == str).Key;
            if (key is not null) return key;
            else return null; 
        }

        public static List<int> No6(int[] arr)
        {
            var notFoundedNumbers = new List<int>();

            if (arr.Length > 0)
            {
                Array.Sort(arr);

                for (int i = 1; i <= 100; i++)
                {
                    if (!arr.Contains(i))
                    {
                        notFoundedNumbers.Add(i);
                    }
                }
            }


            //if (arr.Length > 0)
            //{
            //    Array.Sort(arr);
            //    int start = 1;
            //    int limit = 100;

            //    if (arr[0] > 1) start = arr[0];

            //    if (arr[arr.Length - 1] < 100) limit = arr[arr.Length - 1];

            //    for (int i = start; i <= limit; i++)
            //    {
            //        if (!arr.Contains(i))
            //        {
            //            notFoundedNumbers.Add(i);
            //        }
            //    }
            //}
            return notFoundedNumbers;
        }

        public static List<int> No7(int[] arr)
        {
            var uniqueValues = new List<int>();
            var duplicateValues = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (!uniqueValues.Contains(arr[i]))
                {
                    uniqueValues.Add(arr[i]);
                }
                else
                {
                    duplicateValues.Add(arr[i]);
                }
            }

            return duplicateValues;
        }
    }
}
