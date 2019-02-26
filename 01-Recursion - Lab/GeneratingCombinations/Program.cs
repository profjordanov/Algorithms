using System;
using System.Linq;

namespace GeneratingCombinations
{
	/// <summary>
	/// Generate all n choose k combinations. 
	/// </summary>
	internal class Program
    {
	    private static void Main()
        {
	        var elements = ReadElements();

	        var n = int.Parse(Console.ReadLine());

	        if(n < 0)
	        {
		        return;
	        }

	        var combination = new int[ n ];
	        GenerateCombination(combination, elements, 0, 0);
		}

	    private static int[] ReadElements() =>
		    Console.ReadLine()?
			    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
			    .Select(int.Parse)
			    .ToArray();

	    private static void GenerateCombination(int[] combination, int[] elements, int index, int border)
	    {
		    if (index == combination.Length)
		    {
				Console.WriteLine(string.Join(" ", combination));
			}
		    else
		    {
			    for (var i = border; i < elements.Length; i++)
			    {
				    combination[index] = elements[i];
				    GenerateCombination(combination, elements, index + 1, i + 1);
				}
		    }
	    }
	}
}
