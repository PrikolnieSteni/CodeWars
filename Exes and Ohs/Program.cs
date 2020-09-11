using System;
using System.Linq;

namespace Exes_and_Ohs
{
    class Program
    {

        public static bool XO(string input)
        {
            int[] values = { 0, 0 };
            bool return_value = false;
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i].ToString().ToLower())
                {
                    case "x": values[0]++; break;
                    case "o": values[1]++; break;
                }
            }
            if(values[0] == values[1] || (values[0] == 0 && values[1] == 0))
            {
                return_value = true;
            }
            return return_value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(XO("ooxx"));
            Console.WriteLine(XO("xooxx"));
            Console.WriteLine(XO("ooxXm"));
            Console.WriteLine(XO("zpzpzpp"));
            Console.WriteLine(XO("zzoo"));
        }
    }
}
