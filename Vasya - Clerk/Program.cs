using System;

namespace Vasya___Clerk
{
    class Program
    {
        public static string Tickets(int[] peopleInLine)
        {
            int bill_50 = default;
            int bill_25 = default;
            string return_value = "YES";
            for (int i = 0; i < peopleInLine.Length; i++)
            {
                switch (peopleInLine[i])
                {
                    case 25:
                        bill_25++;
                        break;
                    case 50:
                        if (bill_25 > 0)
                        {
                            bill_50++;
                            bill_25--;
                        }
                        else
                        {
                            return_value = "NO";
                        }
                        break;
                    case 100:
                        if (bill_25 > 0 && bill_50 > 0)
                        {
                            bill_50--;
                            bill_25--;
                        }
                        else if (bill_25 > 2)
                        {
                            bill_25 -= 3;
                        }
                        else
                        {
                            return_value = "NO";
                        }
                        break;
                }
            }
            return return_value;
        }

        static void Main(string[] args)
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 };
            Console.WriteLine(Tickets(peopleInLine));
        }
    }
}
