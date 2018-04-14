using System;
using System.Collections.Generic;
using System.Text;

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
            int countC = 0;
            int countB = 0;
            int res = 1;
            while(b < c)
            {
                c--;
                countC++;
            }
            a += countC;
            if (a == b)
            {
                res = countC * 2;
                Console.WriteLine(res);
            }
            else
            {
                while(a < b)
                {
                    b--;
                    countB++;
                }
                res = countC * 2;
                res += countB;
                Console.Write(res);
            }
        }
    }
}
