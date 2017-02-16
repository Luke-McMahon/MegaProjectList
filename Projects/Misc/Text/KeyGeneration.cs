using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace Misc.Text
{
    internal class KeyGeneration
    {
        public static void Generate()
        {
            Console.WriteLine("Generating Key...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(CreateKey());
            Console.WriteLine("Generated key.");
        }

        private static string CreateKey()
        {
            Guid serialGuid = Guid.NewGuid();
            string uniqueSerial = serialGuid.ToString("N");

            string uniqueSerialLength = uniqueSerial.Substring(0, 28);

            char[] serialArray = uniqueSerialLength.ToCharArray();
            string finalNumber = "";

            int j = 0;
            for (int i = 0; i < 28; i++)
            {
                for (j = i; j < 4 + i; j++)
                {
                    finalNumber += serialArray[j];
                }

                if (j == 28)
                    break;

                i = (j) - 1;
                finalNumber += "-";
            }
            return finalNumber;
        }
    }
}
