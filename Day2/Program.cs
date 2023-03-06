namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var no_1 = Part1.No1(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }, 24);
            
            Console.WriteLine(Part1.No2(new int[] { 4,455,7,59,45,5487,8,2,18,4,121,487}));
            
            Console.WriteLine(Part1.No4("pbklcNHkeRDuuuipdHFL"));

            Dictionary<string, string> forNo_5 = new Dictionary<string, string>()
            {
                { "Lang 1", "C#" },
                { "Lang 2", "C++" },
                { "Lang 3", "JS" },
                { "Lang 4", "Java" },
                { "Lang 5", "Python" },
            };
            Console.WriteLine(Part1.No5(forNo_5, "JS"));

            var no_6 = Part1.No6(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 84, 654, 65, 86 });

            var no_7 = Part1.No7(new int[] { 4,455,7,59,45,5487,8,2,18,4,121,487, 59});

        }
    }
}