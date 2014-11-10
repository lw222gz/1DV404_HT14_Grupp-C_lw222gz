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
                int number = 0;
                int NextHighest = -2147483648;
                int Highest = 0;
                bool loop = true;
                do
                {
                    try
                    {
                        Console.WriteLine("Ange 10 värden:");
                        Console.Write("Tal 1:   ");
                        number = int.Parse(Console.ReadLine());
                        Highest = number;
                        loop = true;
                    }
                    catch
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("FEL! Du måste ange ett heltal i rätt format.");
                        Console.ResetColor();
                        loop = false;
                    }
                } while (loop == false);
                for (int i = 0; i < 9; i++)
                {
                    try
                    {
                        Console.Write("Tal {0}:   ", i + 2);
                        number = int.Parse(Console.ReadLine());

                        if (number > Highest)
                        {
                            NextHighest = Highest;
                            Highest = number;
                        }
                        if (number > NextHighest && number < Highest)
                        {
                            NextHighest = number;
                        }

                        if (i == 8)
                        {
                            Console.WriteLine("{0} är det näst högsta talet.", NextHighest);
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
                Console.BackgroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Tryck valfri tangent för att köra om - ESC avslutar.");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
