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
            char[] letters = s.ToCharArray();
            char[] lettersReversed = letters.Reverse().ToArray();
            int letterPalin = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == lettersReversed[i])
                    letterPalin++;
            }

            return s + (letterPalin == letters.Length ? " is" : " is not") + " palindromic";
        }

    }
}
