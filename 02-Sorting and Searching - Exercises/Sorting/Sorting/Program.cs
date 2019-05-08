using System;
using System.Diagnostics;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
	        var array = new int[] {5, 4, 3};
			Console.WriteLine("Array: " + string.Join(' ', array));

			#region InsertionSort

			var stopWatch = new Stopwatch();
			stopWatch.Start();
			var insertionSortResult = InsertionSort.Sort(array);
			stopWatch.Stop();
			var ts = stopWatch.Elapsed;
			// Format and display the TimeSpan value. 
			var elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
			Console.WriteLine("Insertion Sort RunTime " + elapsedTime);
			Console.WriteLine("Insertion Sort Result " + string.Join(' ', insertionSortResult));

			#endregion

			#region BubbleSort

			stopWatch = new Stopwatch();
			stopWatch.Start();
			var bubbleSortResult = BubbleSort.Sort(array);
			stopWatch.Stop();
			ts = stopWatch.Elapsed;
			// Format and display the TimeSpan value. 
			elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
			Console.WriteLine("Bubble Sort RunTime " + elapsedTime);
			Console.WriteLine("Bubble Sort Result " + string.Join(' ', insertionSortResult));

			#endregion

			#region BubbleSort

			stopWatch = new Stopwatch();
			stopWatch.Start();
			var shellSortResult = ShellSort.Sort(array);
			stopWatch.Stop();
			ts = stopWatch.Elapsed;
			// Format and display the TimeSpan value. 
			elapsedTime = $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{ts.Milliseconds / 10:00}";
			Console.WriteLine("Shell Sort RunTime " + elapsedTime);
			Console.WriteLine("Shell Sort Result " + string.Join(' ', shellSortResult));

			#endregion
		}
	}
}
