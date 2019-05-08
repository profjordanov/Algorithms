using System;

namespace Sorting
{
	/// <summary>
	/// Sorting algorithm that builds the final sorted array (or list) one item at a time.
	/// </summary>
	public class InsertionSort
	{
		public static int[] Sort(int[] inputArray)
		{
			for (var i = 0; i < inputArray.Length - 1; i++)
			{
				for (var j = i + 1; j > 0; j--)
				{
					if (inputArray[j - 1] <= inputArray[j])
					{
						continue;
					}

					var temp = inputArray[j - 1];
					inputArray[j - 1] = inputArray[j];
					inputArray[j] = temp;
				}
			}

			return inputArray;
		}

		public static int[] SortByShift(int[] inputArray)
		{
			for (var i = 0; i < inputArray.Length; i++)
			{
				int j;
				var insertionValue = inputArray[i];
				for (j = i; j > 0; j--)
				{
					if (inputArray[j - 1] > insertionValue)
					{
						inputArray[j] = inputArray[j - 1];
					}
				}

				inputArray[j] = insertionValue;
			}

			return inputArray;
		}
	}
}