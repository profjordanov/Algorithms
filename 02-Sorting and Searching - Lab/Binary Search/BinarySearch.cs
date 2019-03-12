namespace Binary_Search
{
	/// <summary>
	/// Divide-and-conquer algorithm.
	/// </summary>
	public class BinarySearch
	{
		public static int IndexOf(int[] arr, int key)
		{
			// variables defining the bounds
			var lo = 0;
			var hi = arr.Length - 1;

			while(lo <= hi)
			{
				// starts at the middle of the collection
				var mid = lo + (hi - lo) / 2;
				// if the key is to the left of the midpoint, move the right bound. 
				if(key < arr[mid])
				{
					hi = mid - 1;
				}
				// if the key is to the right of the midpoint, move the left bound
				else if(key > arr[mid])
				{
					lo = mid + 1;
				}
				else
				{
					return mid;
				}
			}

			return -1;
		}
	}
}