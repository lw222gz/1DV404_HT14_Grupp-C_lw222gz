using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.Write("Skriv in ett tal: ");
                string input = Console.ReadLine();
                int evens = 0;
                int odds = 0;
                int zeroes = 0;
                int j = 0;
                char value;
                int number = 0;

                try
                {
                    for (int i = 0; i < input.Length; ++i)
                    {
                        value = input[j++];         // är detta tillåtet?
                        number = int.Parse(value.ToString());

                        if (number == 0)
                        {
                            ++zeroes;
                        }
                        else if (number % 2 == 0)
                        {
                            ++evens;
                        }
                        else if (number % 2 == 1)
                        {
                            ++odds;
                        }
                        if (i == (input.Length - 1))
                        {
                            Console.WriteLine();
                            Console.WriteLine("Talet innehåller : \nNollor: {0} \nJämna: {1} \nOjämna: {2}", zeroes, evens, odds);
                        }
                    }
                }
                catch
                {
                    Console.WriteLine();
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Du måste ange ett tal i rätt format!");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Tryck valfri tangent för att börja om - ESC avslutar.");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            
        }       
    }
}
