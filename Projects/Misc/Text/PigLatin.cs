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
            const string Vowels = "AEIOUaeiou";
            List<string> pigWords = new List<string>();

            foreach (string word in sentence.Split(' '))
            {
                string firstLetter = word.Substring(0, 1);
                string restOfWord = word.Substring(1, word.Length - 1);
                int currentLetter = Vowels.IndexOf(firstLetter);

                if (currentLetter == -1)
                {
                    pigWords.Add(restOfWord + firstLetter + "ay");
                }
                else
                {
                    pigWords.Add(word + "way");
                }
            }

            return string.Join(" ", pigWords);
        }
    }
}
