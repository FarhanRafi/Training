using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static Day3.Program;

namespace Day3
{
    internal class Part3
    {
        public static int FindMaxValue(int[] arr)
        {
            if(arr == null || arr.Length == 0) return 0;
            else
            {
                int maxValue = arr[0];

                foreach( int i in arr )
                {
                    if( maxValue < i ) maxValue = i;
                }

                return maxValue;
            }

        }

        public static int FindMinValue(int[] arr)
        {
            if (arr == null || arr.Length == 0) return 0;
            else
            {
                int minValue = arr[0];

                foreach (int i in arr)
                {
                    if (minValue > i) minValue = i;
                }

                return minValue;
            }

        }

        public static void ConvertingToListAndPrint(int[] arr)
        {
            if (arr is not null)
            {
                arr.ToList();

                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }
            }

        }


        public static void RemoveDuplicatesAndPrint(List<string> strings)
        {
            if (strings is not null)
            {
                strings = strings.Distinct().ToList();

                foreach (var item in strings)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public static bool IsPotatoThere(List<string> groceries)
        {
            if(groceries.Contains("Potato")) return true;
            return false;
        }

        public static void UpdatedArrayList(List<string> strings, string str)
        {
            if (strings is not null)
            {
                var index = strings.IndexOf(str);
                strings[index] = str;
            }
        }


        public static Address ConstructAddressbook(List<Address> addressBook, string key, string[] strings)
        {
            int keyCount = addressBook.Count;
            //var address = new Address { Name = new Dictionary<string, string>() { $"Individual {++keyCount}", key} };
            var address = new Address() { };
            address.Name.Add($"Individual {++keyCount}", key);

            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine($"{strings[i]}"); 
                Console.WriteLine($"Address {i + 1}"); 
                address.Addresses.Add($"Address {i+1}", $"{strings[0]}");
            }
            addressBook.Add(address);

            return address;
        }
    }

    public class Address
    {
        public Dictionary<string, string> Name { get; set; }
        public Dictionary<string, string> Addresses { get; set; }
    }
}
