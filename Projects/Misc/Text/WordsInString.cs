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
            string[] split = s.Split(' ');
            
            return $"'{s}' has {split.Length} " + (split.Length == 1 ? "word." : "words.");
        }
    }
}
