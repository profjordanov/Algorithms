using System;

namespace Merge_Sort
{
	public static class MergeSort<T>
		where T : IComparable
	{
		// auxiliary array that helps with merging sub-arrays
		private static T[] _aux;

		public static void Sort(T[] arr)
		{
			_aux = new T[ arr.Length ];
			Sort(arr, 0, arr.Length - 1);
		}

		// recursive sort method
		private static void Sort(T[] arr, int lo, int hi)
		{
			// if there is only one element in the sub-array, it is already sorted
			if(lo >= hi)
			{
				return;
			}

			var mid = lo + (hi - lo) / 2;

			// splits array into two sub-arrays
			// sorts them recursively 
			Sort(arr, lo, mid);
			Sort(arr, mid + 1, hi);
			// merge them on the way up of the recursion(as a post - action)
			Merge(arr, lo, mid, hi);
		}

		private static void Merge(T[] arr, int lo, int mid, int hi)
		{
			// as the two sub-arrays are sorted, if the largest element in the left is smaller than the smallest
			// in the right, the two sub-arrays are already merged

			if (IsLess(arr[mid], arr[mid + 1]))
			{
				return;
			}

			// transfers all elements to the auxiliary array
			for(var index = lo; index < hi + 1; index++)
			{
				_aux[index] = arr[index];
			}

			// merges them back in the main array
			var i = lo;
			var j = mid + 1;

			for (var k = lo; k <= hi; k++)
			{
				if (i > mid)
				{
					arr[k] = _aux[j++];
				}
				else if (j > hi)
				{
					arr[k] = _aux[i++];
				}
				else if(IsLess(_aux[i], _aux[j]))
				{
					arr[k] = _aux[i++];
				}
				else
				{
					arr[k] = _aux[j++];
				}
			}
		}

		private static bool IsLess(T current, T other) =>
			current.CompareTo(other) < 0;
	}
}