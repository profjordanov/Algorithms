using System;

namespace Recursive_Drawing
{
	/// <summary>
	/// Program that draws the figure below depending on n by recursion.
	/// </summary>
	internal class Program
    {
	    private static void Main()
        {
	        var n = int.Parse(Console.ReadLine());
	        Draw(n);
		}

	    private static void Draw(int n)
	    {
		    if (n < 0)
		    {
			    return;
		    }

			Console.WriteLine(new string('*', n));
			Draw(n - 1);
			Console.WriteLine(new string('#', n));
	    }
    }
}
