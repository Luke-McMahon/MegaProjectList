using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class VowelCount
    {
        private static char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        private static string word = "hiya";

        public static int Init(string s)
        {
            int counted = 0;

            foreach (char c in s)
            {
                int isVowel = Array.IndexOf(vowels, c);
                if (isVowel > -1)
                {
                    counted++;
                }
            }

            return counted;
        }
    }
}
