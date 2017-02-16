using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class StringReverse
    {
        public static string ToReverse = "This should be reversed";



        public static void Init()
        {
            Console.WriteLine("Enter a word/sentence to be reversed.");
            Console.WriteLine(Reverse(Console.ReadLine()));
        }

        private static string Reverse(string s)
        {
            char[] reversed = s.ToCharArray().Reverse().ToArray();
            string result = "";

            foreach (char c in reversed)
            {
                result += c;
            }

            return result;
        }
    }
}
