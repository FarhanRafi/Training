namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Lambda expression
            var countries = new[] { "Bangladesh", "Australia", "Pakistan", "Sri Lanka", "Canada", "New Zealand" };
            var sortedByName = countries.OrderBy(name => name).Take(5).ToList();

            // 2. ForEach()
            sortedByName.ForEach(name => Console.WriteLine(name));

            // 3. Functional interface
    
        }
    }
}