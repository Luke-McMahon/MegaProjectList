using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class VowelCount
    {
		// keep these around, these are important
        private static readonly char[] vowels = {'a', 'e', 'i', 'o', 'u'};
		// this gets changed, don't worry :)
        private static string word = "hiya";

        public static void Init()
        {
            Console.WriteLine("Enter a word/sentence to find the sum of the vowels.");
            Console.WriteLine(VowelsCounted(Console.ReadLine()));
        }

        private static string VowelsCounted(string s)
        {
			// keep track of the amount of vowels with this variable
            int counted = 0;
			// change our word variable to the word/words input by the user
            word = s;

			// loop through every character in the word/words
            foreach (char c in s)
            {
				// find the index of our current character if it's in the vowels array
                int isVowel = Array.IndexOf(vowels, c);
				// if it is
                if (isVowel > -1)
                {
					// increment the amount of vowels we've counted
                    counted++;
                }
            }
            
			// output the amount of vowels we have counted
            return "There "+ (counted == 1 ? "is " : "are ")+ + counted + (word.Length > 1 ? " vowels." : " vowel.");
        }
    }
}
