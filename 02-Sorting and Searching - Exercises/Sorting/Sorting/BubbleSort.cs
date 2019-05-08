namespace Sorting
{
	/// <summary>
	///  Sorting algorithm that repeatedly steps through the list, compares adjacent pairs and swaps them if they are in the wrong order. 
	/// </summary>
	public class BubbleSort
	{
		public static int[] Sort(int[] arr)
		{
			for (var j = 0; j <= arr.Length - 2; j++)
			{
				for (var i = 0; i <= arr.Length - 2; i++)
				{
					if (arr[i] <= arr[i + 1])
					{
						continue;
					}

					var temp = arr[i + 1];
					arr[i + 1] = arr[i];
					arr[i] = temp;
				}
			}

			return arr;
		}
	}
}