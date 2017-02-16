using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class Palindrome
    {
        public static void CheckIfPalindrome()
        {
            Console.WriteLine("Enter a word to see if it's palindromic. (Mum, Dad, racecar, etc.)");
            Console.WriteLine(IsTrue(Console.ReadLine()));
        }

        private static string IsTrue(string s)
        {
			// the letters that the user input
            char[] letters = s.ToCharArray();
			// the same letters, but reversed
            char[] lettersReversed = letters.Reverse().ToArray();
            int letterPalin = 0;

			// loop through all the letters we were given
            for (int i = 0; i < letters.Length; i++)
            {
				// if the current index of letters we're at is the same as the reversed letters index
                if (letters[i] == lettersReversed[i])
                    letterPalin++; // this isn't a great way to do this, i know.
            }

			// if the amount of 'letterPalin' is the same as the letters we were given, it's palindromic
            return s + (letterPalin == letters.Length ? " is" : " is not") + " palindromic";
        }

    }
}
