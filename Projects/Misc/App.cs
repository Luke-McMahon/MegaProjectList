using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Misc.Text;

namespace Misc
{
    internal class App
    {

        private static void Main()
        {
            Run();
           

            Console.Read();
        }

        private static void Run()
        {
            StringReverse.Init();

            Console.WriteLine("");
            PigLatin.Init();

            Console.WriteLine("");
            VowelCount.Init();

            Console.WriteLine("");
            Palindrome.CheckIfPalindrome();

            Console.WriteLine("");
            WordsInString.Init();

            Console.WriteLine("");
            KeyGeneration.Generate();
        }
    }
}
