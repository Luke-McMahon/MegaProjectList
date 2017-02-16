using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class VowelCount
    {
        private static readonly char[] vowels = {'a', 'e', 'i', 'o', 'u'};
        private static string word = "hiya";

        public static void Init()
        {
            Console.WriteLine("Enter a word/sentence to find the sum of the vowels.");
            Console.WriteLine(VowelsCounted(Console.ReadLine()));
        }

        private static string VowelsCounted(string s)
        {
            int counted = 0;
            word = s;

            foreach (char c in s)
            {
                int isVowel = Array.IndexOf(vowels, c);
                if (isVowel > -1)
                {
                    counted++;
                }
            }
            
            return "There "+ (counted == 1 ? "is " : "are ")+ + counted + (word.Length > 1 ? " vowels." : " vowel.");
        }
    }
}
