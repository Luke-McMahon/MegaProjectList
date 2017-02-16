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
			// create a new guid instance
            Guid serialGuid = Guid.NewGuid();
			// force the serial to be numeric
            string uniqueSerial = serialGuid.ToString("N");

			// specify a particular length
            string uniqueSerialLength = uniqueSerial.Substring(0, 28);

			// create an array to hold the characters of the serial
            char[] serialArray = uniqueSerialLength.ToCharArray();
			// this is the actual key
            string finalNumber = "";

            int j = 0;
            for (int i = 0; i < 28; i++)
            {
                for (j = i; j < 4 + i; j++)
                {
					// set the key
                    finalNumber += serialArray[j];
                }

				// if we're at the 28th index, we're finished!
                if (j == 28)
                    break;

                i = (j) - 1;
                finalNumber += "-";
            }
            return finalNumber;
        }
    }
}
