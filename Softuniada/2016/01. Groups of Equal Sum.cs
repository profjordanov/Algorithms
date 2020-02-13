using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            var d = int.Parse(Console.ReadLine());

            var halfSum = (a + b + c + d) / 2.0;

            if (a == halfSum ||
                b == halfSum || 
                c == halfSum || 
                d == halfSum ||
                a + b == halfSum ||
                a + c == halfSum ||
                a + d == halfSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(halfSum);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
