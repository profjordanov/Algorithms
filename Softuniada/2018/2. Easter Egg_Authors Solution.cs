using System;
using System.Collections.Generic;
using System.Text;

namespace Softuniada
{
    class ЕasterEgg
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 5 * n;
            int height = 2 * n + 3;
            
            String firstAndLastRow = new string('.', 2 * n)
                    + new string('*', n)
                    + new string('.', 2 * n);

            Console.WriteLine(firstAndLastRow);
           

            for (int i = 0; i < n / 2; i++)
            {
                String bodyUpperPart1 = new string('.', (2 * n - 2) - 2 * i)
                        + new string('*', 1 + i)
                        + new string('+', (n + 2) + 2 * i)
                        + new string('*', 1 + i)
                        + new string('.', (2 * n - 2) - 2 * i);

                Console.WriteLine(bodyUpperPart1);

            }

            for (int i = 0; i < n / 2; i++)
            {
                String bodyUpperPart2 = new string('.', n - 1 - i)
                        + "**"
                        + new string('=', 3 * n - 2 + 2 * i)
                        + "**"
                        + new string('.', n - 1 - i);

                Console.WriteLine(bodyUpperPart2);

            }

            String middleRow = new string('.', n / 2)
                    + "**"
                    + new string('~', (4 * n - 16) / 2)
                    + "HAPPY EASTER"
                    + new string('~', (4 * n - 16) / 2)
                    + "**"
                    + new string('.', n / 2);

            Console.WriteLine(middleRow);
            
            for (int i = 0; i < n / 2; i++)
            {
                String bodyDownPart1 = new string('.', (n / 2) + i)
                        + "**"
                        + new string('=', (4 * n - 4) - 2 * i)
                        + "**"
                        + new string('.', (n / 2) + i);

                Console.WriteLine(bodyDownPart1);
            }
            for (int i = 0; i < n / 2; i++)
            {
                String bodyDownPart2 = new string('.', n + 2 * i)
                        + new string('*', n / 2 - i)
                        + new string('+', 2 * n - 2 * i)
                        + new string('*', n / 2 - i)
                        + new string('.', n + 2 * i);

                Console.WriteLine(bodyDownPart2);

            }
            Console.WriteLine(firstAndLastRow);
        }
    }
}
