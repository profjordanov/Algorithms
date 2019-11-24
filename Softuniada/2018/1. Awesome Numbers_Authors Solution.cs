using System;
using System.Collections.Generic;
using System.Text;

namespace Softuniada
{
    class AwesomeNumbers
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int favouriteNumber = int.Parse(Console.ReadLine());

            var isOdd = number % 2 != 0;
            var isNegative = number < 0;
            var isDivisible = number % favouriteNumber == 0;

            if (!isOdd && !isNegative && !isDivisible)
            {
                Console.WriteLine("boring");
            }

            if ((isOdd && !isNegative && !isDivisible) ||
                (!isOdd && isNegative && !isDivisible) ||
                (!isOdd && !isNegative && isDivisible))
            {
                Console.WriteLine("awesome");
            }

            if ((isOdd && isNegative && !isDivisible) ||
                (isOdd && !isNegative && isDivisible) ||
                (!isOdd && isNegative && isDivisible))
            {
                Console.WriteLine("super awesome");
            }

            if (isOdd && isNegative && isDivisible)
            {
                Console.WriteLine("super special awesome");
            }

        }
    }
}
