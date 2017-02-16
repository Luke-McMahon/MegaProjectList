using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class PigLatin
    {

        public static void Init()
        {
            Console.WriteLine("Enter a word/sentence to translate into Pig Latin.");
            Console.WriteLine(Pigify(Console.ReadLine()));
        }

        private static string Pigify(string sentence)
        {
			// these are vowels, we need these
            const string Vowels = "AEIOUaeiou";
			// a dynamic list of string to add our words to
            List<string> pigWords = new List<string>();

			// loop through each word in the sentence
            foreach (string word in sentence.Split(' '))
            {
				// take the first letter of our current word
                string firstLetter = word.Substring(0, 1);
				// take the late letter of our current word
                string restOfWord = word.Substring(1, word.Length - 1);
				// if the current letter a vowel
                int currentLetter = Vowels.IndexOf(firstLetter);

				// if it is
                if (currentLetter == -1)
                {
					// create a new pigword with the first letter at the end of the word, adding "ay"
                    pigWords.Add(restOfWord + firstLetter + "ay");
                }
				// if it isnt
                else
                {
					// create a new pigword with the entire word, adding "way"
                    pigWords.Add(word + "way");
                }
            }

			// join all the pigwords, spacing after each one, and output the result
            return string.Join(" ", pigWords);
        }
    }
}
