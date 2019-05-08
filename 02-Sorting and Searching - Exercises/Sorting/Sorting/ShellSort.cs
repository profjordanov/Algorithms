using System;

namespace Sorting
{
	/// <summary>
	/// Highly efficient sorting algorithm and is based on insertion sort algorithm.
	/// This algorithm avoids large shifts as in case of insertion sort,
	/// if the smaller value is to the far right and has to be moved to the far left.
	/// </summary>
	public class ShellSort
	{
		public static int[] Sort(int[] array)
		{
			var pos = 3;
			if (array.Length < pos)
			{
				throw new ArgumentOutOfRangeException($"Array length cannot be less than {pos}!");
			}
			while (pos > 0)
			{
				int i;
				for (i = 0; i < array.Length; i++)
				{
					var j = i;
					var temp = array[i];
					while (j >= pos &&
					       array[j - pos] > temp)
					{
						array[j] = array[j - pos];
						j = j - pos;
					}

					array[j] = temp;
				}

				if (pos / 2 != 0)
				{
					pos = pos / 2;
				}
				else if (pos == 1)
				{
					pos = 0;
				}
				else
				{
					pos = 1;
				}
			}

			return array;
		}
	}
}