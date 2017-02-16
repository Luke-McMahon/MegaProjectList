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
			// create an array from the user input and reverse it
            char[] reversed = s.ToCharArray().Reverse().ToArray();
            string result = "";

			// loop through each character in the reversed array
            foreach (char c in reversed)
            {
				// add the character to our resulting string
                result += c;
            }

			// output the reversed result
            return result;
        }
    }
}
