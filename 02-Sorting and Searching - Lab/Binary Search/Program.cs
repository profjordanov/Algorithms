using System;
using System.Linq;

namespace Binary_Search
{
    class Program
    {
        static void Main(string[] args)
        {
	        var input = Console.ReadLine();
	        var key = int.Parse(Console.ReadLine());

	        if(input == string.Empty)
	        {
		        return;
	        }

	        var arr = input
		        .Split()
		        .Select(int.Parse)
		        .ToArray();

	        var index = BinarySearch.IndexOf(arr, key);
	        Console.WriteLine(index);
		}
    }
}
