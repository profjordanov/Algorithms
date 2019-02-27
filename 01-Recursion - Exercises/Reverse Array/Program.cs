using System;
using System.Linq;

namespace Reverse_Array
{
	/// <summary>
	/// A program that reverses and prints an array. Used recursion.
	/// </summary>
	internal class Program
    {
	    private static void Main()
        {
	        var arr = Console.ReadLine()?
		        .Split()
		        .Select(int.Parse)
		        .ToArray();

	        Reverse(arr, 0, arr.Length - 1);

	        Console.WriteLine(string.Join(" ", arr));
		}

	    private static void Reverse(int[] arr, int start, int end)
	    {
		    if (start >= end)
		    {
			    return;
		    }

		    var temp = arr[start];
		    arr[start] = arr[end];
		    arr[end] = temp;

			Reverse(arr, start + 1, end - 1);
	    }
    }
}
