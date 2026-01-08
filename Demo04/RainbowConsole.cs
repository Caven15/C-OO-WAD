using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    internal static class RainbowConsole
    {
        public static void WriteLine(string text)
        {
            Write(text);
            Console.WriteLine();
        } 

        public static void Write(string text)
        {
            int i = 0;
            foreach (char caractere in text)
            {
                int length = Enum.GetValues<ConsoleColor>().Length;
                Console.BackgroundColor = (ConsoleColor)(i % length);
                Console.ForegroundColor = (ConsoleColor)(length-1 - (i % length));
                i++;
                Console.Write(caractere);
            }
            Console.ResetColor();
        }
    }
}
