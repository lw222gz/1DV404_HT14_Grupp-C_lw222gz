using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RaknaNaststorsta
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                int number = 0;
                int NextHighest = 0;
                int Highest = 0;
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        Console.Write("Tal {0}: ", i + 1);
                        number = int.Parse(Console.ReadLine());
                        if (number > Highest) // Sätter highest om det blir ett nytt högsta tal och nexthighest till det förra högsta talet
                        {
                            NextHighest = Highest;
                            Highest = number;
                        }
                        else if (number > NextHighest && number != Highest) // sätter next highest till ett nytt next highet om heighest in fått nått nytt högre värde men det näst högsta värdet har.
                        {
                            NextHighest = number;
                        }
                        if (number < 0 && i == 0) // Sätter Highest om det första talet är under 0
                        {
                            Highest = number;
                        }
                        if (number < Highest && i == 1) // sätter det näst högsta talet om det andra talet är under det 
                        {
                            NextHighest = number;
                        }                       
                    }
                    catch
                    {
                        --i;
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("FEL! Du måste ange ett heltal i rätt format.");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
                Console.WriteLine("{0} är det näst högsta talet.", NextHighest);
                Console.WriteLine();

                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Tryck valfri tangent för att köra om - ESC avslutar.");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}