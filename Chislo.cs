using System;
using System.Collections.Generic;

namespace ConsoleApplication4
{
    class Program
    {
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


            for (int i = 1; i < array.Length - 1; i++)
            {
                if (Math.Abs(array[i - 1] - c) < Math.Abs(array[i] - c))
                {
                    Console.WriteLine(array[i - 1]);
                }
                else
                {
                    Console.WriteLine(array[i]);
                }
            }

            //var closest = array.Where(numbers => numbers > number).First();

            //int closest = array.OrderBy(item => Math.Abs(number - item)).First();

            //int closest = array.Aggregate((x, y) => Math.Abs(x - number) < Math.Abs(y - number) ? x : y);

        }
    }
}
