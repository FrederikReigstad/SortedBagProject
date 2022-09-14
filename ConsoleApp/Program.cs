using SortedBagProject.Implementation;
using SortedBagProject.Interfaces;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISortedBag bag = new SortedBag();
            for (int i = 5; i > 0; i--)
                bag.Add(i);

            while (!bag.IsEmpty)
                Console.WriteLine($"{bag.Fetch(),2}");
        }
    }
}