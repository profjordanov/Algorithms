using System;

namespace Quicksort
{
	/// <summary>
	/// Sorting class.
	/// </summary>
	public class Quick
	{
		/// <summary>
		/// Sorting method.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="arr"></param>
		public static void Sort<T>(T[] arr)
			where T : IComparable
		{
			Shuffle(arr);
			Sort(arr, 0, arr.Length - 1);
		}

		private static void Sort<T>(T[] arr, int lo, int hi)
			where T : IComparable
		{
			if(lo >= hi)
			{
				return;
			}
			// finds the pivot index and rearrange the elements
			var pivot = Partition(arr, lo, hi);
			// sort the left and right partitions recursively
			Sort(arr, lo, pivot - 1);
			Sort(arr, pivot + 1, hi);
		}

		// choose the pivot point
		private static int Partition<T>(T[] arr, int lo, int hi)
			where T : IComparable
		{
			// if there is only one element, it is already partitioned and the index of the pivot is the index of its only element
			if(lo >= hi)
			{
				return lo;
			}

			var i = lo;
			var j = hi + 1;

			while (true)
			{
				while (Less(arr[++i], arr[lo]))
				{
					if (i == hi)
					{
						break;
					}
				}

				while (Less(arr[lo], arr[--j]))
				{
					if (j == lo)
					{
						break;
					}
				}

				if (i >= j)
				{
					break;
				}

				Swap(arr, i, j);
			}
			Swap(arr, lo, j);
			return j;
		}

		private static bool Less<T>(T current, T other)
			where T : IComparable =>
			current.CompareTo(other) < 0;

		private static void Swap<T>(T[] arr, int first, int second)
		{
			var temp = arr[ first ];
			arr[ first ] = arr[ second ];
			arr[ second ] = temp;
		}

		private static void Shuffle<T>(T[] source)
			where T : IComparable
		{
			var rnd = new Random();

			for(var i = 0; i < source.Length; i++)
			{
				// Exchange array[i] with random element in array[i … n-1]

				var r = i + rnd.Next(0, source.Length - i);

				T temp = source[ i ];
				source[ i ] = source[ r ];
				source[ r ] = temp;
			}
		}
	}
}