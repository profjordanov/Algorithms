using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string time1 = Console.ReadLine();
            var time1Tokens = ParseTime(time1);

            string time2 = Console.ReadLine();
            var time2Tokens = ParseTime(time2);

            int minutes = time1Tokens[2] + time2Tokens[2];
            int hours = time1Tokens[1] + time2Tokens[1];
            int days = time1Tokens[0] + time2Tokens[0];

            hours += minutes / 60;
            minutes = minutes % 60;

            days += hours / 24;
            hours = hours % 24;

            if (days > 0)
            {
                Console.Write(days + "::");
            }
            Console.Write(hours + ":");
            if (minutes < 10)
            {
                Console.Write("0");
            }
            Console.WriteLine(minutes);
        }

        static int[] ParseTime(string time)
        {
            if (time.IndexOf("::") == -1)
            {
                time = "0::" + time;
            }
            time = time.Replace("::", ":");
            int[] timeTokens = time.Split(':').Select(int.Parse).ToArray();
            return timeTokens;
        }
    }
}
