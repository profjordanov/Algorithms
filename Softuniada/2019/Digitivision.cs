using System;

namespace Exs_01_Digitivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if(a==0 && b==0 && c==0) Console.WriteLine("No digitivision possible.");
            var array = new int[] { a, b, c };
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    for (int k = 0; k < array.Length; k++)
                    {
                        if (i == j || j == k || i == k) continue;
                        int num = array[i] * 100 + array[j] * 10 + array[k];
                        int del = a + b + c;
                        if (num % del == 0)
                        {
                            Console.WriteLine("Digitivision successful!");
                            return;
                        }
                    }
                }
            }

            Console.WriteLine("No digitivision possible.");
        }
    }
}