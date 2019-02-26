using System;

namespace Recursive_Factorial
{
	/// <summary>
	/// Program that finds the factorial of a given number by recursion.
	/// </summary>
	/// <remarks>
	/// In practice recursion should not be used here (instead use an iterative solution), this is just an exercise.
	/// </remarks>
	internal class Program
    {
	    private static void Main()
        {
	        var n = int.Parse(Console.ReadLine());

	        var factorial = Factorial(n);
	        Console.WriteLine(factorial);
		}

	    private static long Factorial(int n) =>
		    n == 0 ? 1 : n * Factorial(n - 1);
    }
}
