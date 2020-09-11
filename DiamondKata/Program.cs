using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondKata
{
    class Program
    {
        private static char separator = '-';
        static void Main(string[] args)
        {
            char baseChar = 'A';
            int baseInt = Convert.ToInt32(baseChar);

            char midPointChar = args[0].ToUpper()[0];
            int midPointInt = Convert.ToInt32(args[0].ToUpper()[0]);

            int delta = midPointInt - baseInt;

            string line = string.Empty;

            for (int i = 0; i <= delta; i++)
            {
                line = buildLine(baseInt, delta, i);
                Console.WriteLine(line);
            }
            for (int i = delta - 1; i >= 0; i--)
            {
                line = buildLine(baseInt, delta, i);
                Console.WriteLine(line);
            }
        }

        private static string buildLine(int baseInt, int delta, int i)
        {
            int currentCharInt = baseInt + i;
            char currentChar = Convert.ToChar(currentCharInt);

            string line = string.Empty;
            int totLen = ((delta + 1) * 2) - 1;

            int deltaWithCurrentChar = (baseInt + delta) - currentCharInt;

            int firstPos = delta - i;
            int lastPos = totLen - deltaWithCurrentChar - 1;

            for (int l = 0; l < totLen; l++)
                line += (((l == firstPos) || (l == lastPos)) ? currentChar : separator).ToString();
       
            return line;
        }
    }
}
