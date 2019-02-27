using System;
using System.Collections.Generic;

namespace Nested_Loops_To_Recursion
{
	/// <summary>
	/// Program that simulates the execution of n nested loops from 1 to n which prints the values of all its iteration
	/// variables at any given time on a single line. Used recursion.
	/// </summary>
	internal class Program
    {
	    private static int[] _loops;

		private static void Main()
        {
	        var loopsCount = int.Parse(Console.ReadLine());
	        _loops = new int[ loopsCount ];
	        NestedLoops( 0, loopsCount);
		}

		private static void NestedLoops(int currentLoop, int loopsCount)
		{
			if(currentLoop == loopsCount)
			{
				Print(_loops);
				return;
			}

			for (var counter = 1; counter < loopsCount; counter++)
			{
				_loops[currentLoop] = counter;
				NestedLoops(currentLoop + 1, loopsCount);
			}
		}

		private static void Print(IEnumerable<int> loops) =>
			Console.WriteLine(string.Join(" ", loops));

    }
}
