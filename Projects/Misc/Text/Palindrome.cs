using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class Palindrome
    {
        public static bool IsTrue(string s)
        {
            char[] letters = s.ToCharArray();
            char[] lettersReversed = letters.Reverse().ToArray();
            int letterPalin = 0;

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == lettersReversed[i])
                    letterPalin++;
            }

            return letterPalin == letters.Length;
        }

    }
}
