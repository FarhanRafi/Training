/*
 * Uncomment console.writeline to view the expected output
*/

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //Console.WriteLine(Part1.No9("nVgLzIfOlNwneIq", 'I'));

            Dictionary<string, string> forNo_10 = new()
            {
                { "Lang 1", "C#" },
                { "Lang 2", "C++" },
                { "Lang 3", "JS" },
                { "Lang 4", "Java" },
                { "Lang 5", "Python" },
            };
            //Console.WriteLine(Part1.No10(forNo_10, "Lang 1"));
            #endregion

            #region Part 2

            var arrayLinear = new Part2.LinearArray();
            arrayLinear.InitArray(5);
            arrayLinear.StoreData(0, 77);
            arrayLinear.StoreData(2, 23);
            arrayLinear.StoreData(4, 89);
            arrayLinear.StoreData(1, 8);
            arrayLinear.StoreData(3, 0);
            //arr.PrintAll();

            var array_2d = new Part2.Array2D();
            array_2d.InitArray(3, 2);
            array_2d.StoreData(0, 0, 777);
            array_2d.StoreData(0, 1, 575);
            array_2d.StoreData(1, 0, 45);
            array_2d.StoreData(1, 1, 6);
            array_2d.StoreData(2, 0, 23);
            array_2d.StoreData(2, 1, 687);
            //array_2d.PrintAll();

            var listExample = new Part2.List();
            listExample.StoreData("Random test string");
            listExample.StoreData("Another random test string");
            //listExample.PrintAll();

            var setExample = new Part2.HashSetExample();
            setExample.StoreData("Bangladesh");
            setExample.StoreData("Australia");
            setExample.StoreData("Canada");
            //setExample.PrintAll();

            var hashTable = new Part2.HashTableExample();
            hashTable.StoreData("Name", "Mohammad");
            hashTable.StoreData("Age", 25);
            hashTable.StoreData("Programming Language", new List<string>() { "C#", "JS", "Java"});
            //hashTable.PrintAll();

            var stackExample = new Part2.StackExample();
            stackExample.StoreData(34);
            stackExample.StoreData(90);
            stackExample.StoreData(7);
            stackExample.PrintAll();
            //Console.WriteLine(stackExample.GetData());

            var queueExample = new Part2.QueueExample();
            queueExample.StoreData("Name");
            queueExample.StoreData("DOB");
            queueExample.StoreData("Address");
            //queueExample.PrintAll();
            #endregion

            #region Part 3
            // 1. (i)
            int[] arr = { 10, 32, 1, 8, 32, 92, 41, 71, 34, 64, 99 };
            //Console.WriteLine($"Max value is: {Part3.FindMaxValue(arr)} & Min value is: {Part3.FindMinValue(arr)}");
            // 1. (ii)
            //Part3.ConvertingToListAndPrint(arr);

            // 2. (i)
            List<string> groceryList = new() { "Eggs", "Cheese", "Chicken", "Milk", "Beef", "Potato", "Carrot", "Eggs", "Eggs" };
            // 2. (ii)
            //Part3.RemoveDuplicatesAndPrint(groceryList);
            // 2. (iii)
            //Part3.UpdatedArrayList(groceryList, "Mutton");

            // 3. (i)
            List<Address> addressBook = new();

            addressBook.Add(Part3.ConstructAddressbook(addressBook, "Akib", new string[] { "Mirpur", "Dhanmondi", "Siddheswari"}));
            addressBook.Add(Part3.ConstructAddressbook(addressBook, "Sajeeb", new string[] { "Lalmatia"}));
            addressBook.Add(Part3.ConstructAddressbook(addressBook, "Niloy", new string[] { "Puran Dhaka", "Rajarbag" }));
            addressBook.Add(Part3.ConstructAddressbook(addressBook, "Ratul", Array.Empty<string>()));

            Console.WriteLine(addressBook);

            #endregion
        }

        
    }
}