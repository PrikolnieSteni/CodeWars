using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Highest_Scoring_Word
{
    class Program
    {
        public static bool Feast(string beast, string dish)
        {
            if (beast.EndsWith(dish[dish.Length - 1]) == true && beast.StartsWith(dish[0]) == true)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Feast("aabbbbb", "asda"));
        }
    }
}
