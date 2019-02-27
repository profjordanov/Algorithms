using System;

namespace Combinations_with_Repetition
{
	/// <summary>
	/// Recursive program for generating and printing all combinations with duplicates of k elements from a set of n elements (k less or = n).
	/// In combinations, the order of elements doesn’t matter, therefore (1 2) and (2 1) are the same combination, meaning that once
	/// you print/obtain (1 2), (2 1) is no longer valid.
	/// </summary>
	internal class Program
    {
	    private static int[] _arr;
		private static void Main()
        {
	        var setCount = int.Parse(Console.ReadLine());
	        var loopsCount = int.Parse(Console.ReadLine());
	        _arr = new int[ loopsCount ];
	        Combinations(setCount);
		}

		private static void Combinations(int setCount, int index = 0, int element = 1)
		{
			if (index >= _arr.Length)
			{
				Print(_arr);
				return;
			}

			for (var i = element; i <= setCount; i++)
			{
				_arr[index] = i;
				Combinations(setCount, index + 1, i);
			}
		}

		private static void Print(int[] arr) =>
			Console.WriteLine(string.Join(" ", arr));
    }
}
