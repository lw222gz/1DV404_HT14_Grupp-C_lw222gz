using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.Write("Mata in din text: ");
                string input = Console.ReadLine();
                char a = 'a';
                char A = 'A';
                int littleCount = 0;
                int bigCount = 0;
                char value;
                int i = 0;

                foreach (char c in input)
                {

                    value = input[i++];
                    if (value == a)
                    {
                        ++littleCount;
                    }
                    if (value == A)
                    {
                        ++bigCount;
                    }
                    if (i == input.Length)
                    {
                        Console.WriteLine("Antal a:{0}\nAntal A:{1}", littleCount, bigCount);
                    }
                }
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Tryck valfri tangent för att börja om - ESC avslutar.");
                Console.ResetColor();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
