using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace Highest_Scoring_Word
{
    class Program
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> CountCharacters = new Dictionary<char, int>();
            string new_str = default;
            foreach (var value in str)
            {
                int count = str.Count(f => f ==value);
                new_str += value.ToString();
                if (new_str.Count(f=>f == value) <= 1)
                {
                    CountCharacters.Add(value, count);
                }
            }   
            return CountCharacters;
            // return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Count("aabbbbb"));
        }
    }
}
