using System;
using System.Linq;

namespace Reverse_Array
{
	/// <summary>
	/// Program that finds the sum of all elements in an integer array.
	/// </summary>
	/// <remarks>
	/// In practice recursion should not be used here (instead use an iterative solution), this is just an exercise.
	/// </remarks>
	class Program
    {
        static void Main(string[] args)
        {
	        var array = Console.ReadLine()?
		        .Split()
		        .Select(int.Parse)
		        .ToArray();

			Console.WriteLine(Sum(array, 0));
        }

		 
        private static int Sum(int[] array, int index)
        {
	        if (index == array.Length)
	        {
		        return 0;
	        }

	        return array[index] + Sum(array, index + 1);
        }

	}
}
