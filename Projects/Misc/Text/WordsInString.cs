using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class WordsInString
    {
        public static void Init()
        {
            Console.WriteLine("Enter a sentence to find the amount of words.");
            Console.WriteLine(Count(Console.ReadLine()));
        }

        private static string Count(string s)
        {
			// Create an array of strings, containing each word from the user input.
			// Splitting each word at a space.
			// "This is a string" -> {"this", "is", "a", "string"}
            string[] split = s.Split(' ');
            
			// s -> user input
			// split.Length -> the length of the array we created above
			// dynamically change the output depending on the amount of words.
			// 1 word output word.
			// >1 words output words.
			// This does make sense, my horrible explaining doesn't.
            return $"'{s}' has {split.Length} " + (split.Length == 1 ? "word." : "words.");
        }
    }
}
