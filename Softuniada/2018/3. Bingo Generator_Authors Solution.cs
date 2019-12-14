using System;
using System.Collections.Generic;
using System.Text;

namespace Softuniada
{
    class BarcodeGenerator
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            int firstDigit1 = number / 1000;
            int firstDigit2 = (number / 10) % 10;
            int secondDigit1 = (number / 100) % 10;
            int secondDigit2 = number % 10;

            String number1 = firstDigit1 + "" + firstDigit2;
            String number2 = secondDigit1 + "" + secondDigit2;

            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            int sum = num1 + num2;
            int count15 = 0;
            int count12 = 0;

            List<int> twelve = new List<int>();
            List<int> fifteen = new List<int>();

            for (int i = num1; i <= sum; i++)
            {
                for (int j = num2; j <= sum; j++)
                {
                    String newNum = i + "" + j;
                    int newNumber = int.Parse(newNum);
                    if (newNumber % 15 == 0)
                    {
                        fifteen.Add(newNumber);
                        count15++;
                    }
                    if (newNumber % 12 == 0)
                    {
                        twelve.Add(newNumber);
                        count12++;
                    }
                }
            }

            Console.Write("Dividing on 12: ");
            foreach (int t in twelve)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
            Console.Write("Dividing on 15: ");
            foreach (int f in fifteen)
            {
                Console.Write(f + " ");
            }
            Console.WriteLine();


            if (count12 > count15 || count12 < count15)
            {
                Console.WriteLine("NO BINGO!");
            }
            else
            {
                Console.WriteLine("!!!BINGO!!!");
            }
        }
        
    }
}