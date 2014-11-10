using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palidrom
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool loop = true;
            do
            {                
                Console.Clear();
                Console.WriteLine("Några palindrom man kan test : apa, du har bra hud, tor enerot, flyg mot dem med tom gylf.");
                Console.WriteLine();
                Console.WriteLine("Skriv in ett Palindrom, du får bara använda små eller bara stora bokstäver (inga tecken heller):");
                string input = Console.ReadLine();
                string poli = input.Replace(" ", "");
                string NewStr = "";               
                char value;                

                if (input == input.ToLower())
                {
                    loop = false;
                }
                else if (input == input.ToUpper())
                {
                    loop = false;
                }
                else
                {
                    loop = true;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Du måste ange bara små eller bara stora bokstäver.");
                    Console.ResetColor();
                }

                if (loop == false)
                {
                    for (int i = 0; i < poli.Length; i++)
                    {
                        value = poli[poli.Length - 1 - i];
                        NewStr = NewStr + value.ToString();
                        if (i == (poli.Length - 1))
                        {
                            if (NewStr == poli)
                            {
                                Console.WriteLine("{0} är ett palindrom", input);
                            }
                            else
                            {
                                Console.WriteLine("{0} är inte ett palindrom.", input);
                            }
                        }
                    }

                }

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Tryck valfri tangent för att börja om - ESC avslutar");
            Console.ResetColor();
            if (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                loop = false;
            }
            else
            {
                loop = true;
            }
        } while (loop == false);

        }
    }
}
