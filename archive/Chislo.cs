using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int[] array = new int[6];

            array[0] = a + b;
            array[1] = a * b;
            array[2] = a + a;
            array[3] = b + b;
            array[4] = a * a;
            array[5] = b * b;

            var x = Closest(c, array);
            Console.WriteLine(x);


        }

        private static int Closest(int num, int[] arr)
        {
            var curr = arr[0];
            var diff = Math.Abs(num - curr);
            for (var val = 0; val < arr.Length; val++)
            {
                var newdiff = Math.Abs(num - arr[val]);
                if (newdiff <= diff)
                {
                    diff = newdiff;
                    curr = arr[val];
                }
            }
            return curr;
        }
}
