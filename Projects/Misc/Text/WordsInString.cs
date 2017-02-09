using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Misc.Text
{
    internal class WordsInString
    {
        public static int Count(string s)
        {
            string[] split = s.Split(' ');

            return split.Length;
        }
    }
}
