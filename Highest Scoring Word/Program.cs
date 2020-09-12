using System;
using System.Linq;

namespace Highest_Scoring_Word
{
    class Program
    {
        private static string RemoveSpace(string value)
        {
            value = value.Replace(" ", "");
            return value;
        }
        public static bool Feast(string beast, string dish)
        {
            if (RemoveSpace(beast).EndsWith(dish[dish.Length-1]) == true && RemoveSpace(beast).StartsWith(dish[0]) == true)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Feast("great blue heron", "garlic naan"));
        }
    }
}
