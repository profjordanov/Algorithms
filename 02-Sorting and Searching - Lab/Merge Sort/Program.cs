using System;
using System.Linq;

namespace Merge_Sort
{
	/// <summary>
	/// Sort an array of elements using the famous merge sort.
	/// </summary>
	internal class Program
    {
        private static void Main()
        {
	        var input = Console.ReadLine();

	        if(input == string.Empty)
	        {
		        return;
	        }

	        var arr = input
		        .Split()
		        .Select(int.Parse)
		        .ToArray();

	        MergeSort<int>.Sort(arr);

	        Console.WriteLine(string.Join(" ", arr));
		}
    }
}
