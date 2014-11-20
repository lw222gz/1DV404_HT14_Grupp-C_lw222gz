using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.b_Fraction
{
    class Program
    {

        static void Main(string[] args)
        {

            do
            {
                int a = 0;
                int b = 0;
                int c = 0;
                int d = 0;
                Fraction fraction = null;

                try
                {
                    Console.Clear();

                    Menu();

                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 0:
                            return;
                        case 1:
                        case 2:
                        case 3:
                            a = ReadFractionValue("Skriv in den första täljaren: ");
                            b = ReadFractionValue("Skriv in den första nämnaren: ");
                            c = ReadFractionValue("Skriv in den andra täljaren: ");
                            d = ReadFractionValue("Skriv in den andra nämnaren: ");
                            fraction = new Fraction(a, b, c, d);
                            break;
                        case 4:
                            a = ReadFractionValue("Skriv in täljaren: ");
                            b = ReadFractionValue("Skriv in nämnaren: ");
                            fraction = new Fraction(a, b, 1, 1);
                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.Blue;
                            Console.WriteLine("En väldigt onödig funktion som skriver ut {0}", fraction.ToString());
                            Console.ResetColor();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();

                    }
                    if (choice == 1)
                    {
                        fraction.Add();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}/{1} + {2}/{3} = {4}", a, b, c, d, fraction.ToString());
                        Console.ResetColor();
                    }
                    else if (choice == 2)
                    {                        
                        fraction.Multiply();
                        Console.WriteLine();
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("{0}/{1} * {2}/{3} = {4}", a, b, c, d, fraction.ToString());
                        Console.ResetColor();
                    }
                    else if (choice == 3)
                    {
                        if (fraction.isEqualTo() == true)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("De angivna bråken är jämna!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("De angivna bråken är inte jämna.");
                            Console.ResetColor();
                        }

                    }



                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEL! Se till så att siffran är inom intervallet och att du inte skriver in bokstäver.");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("========================================================");
                Console.WriteLine("= Klicka valfri tangent för att göra om - ESC avslutar =");
                Console.WriteLine("========================================================");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        
        static void Menu()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("===================================================");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("=                    Bråk tal                     =");
            Console.WriteLine("=                                                 =");
            Console.WriteLine("===================================================");
            Console.ResetColor();
            Console.WriteLine("\n 0.Avsluta.\n\n 1. Addera 2 bråktal\n\n 2. Multiplicera 2 bråktal\n\n 3. Jämnaföra 2 bråktal\n\n 4. Bara skriva in ett bråktal och få det utskrivet");
            Console.WriteLine("===================================================");
            Console.WriteLine();
            Console.ResetColor();
        }
        
        static int ReadFractionValue(string promt)
        {
            int value;
            Console.Write(promt);
            while (true)
            {
                string input = Console.ReadLine();
                try
                {                   
                    value = int.Parse(input);
                    return value;
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("FEL! {0} är inte i önskat format, var vänlig och ange ett tal.", input);
                    Console.ResetColor();
                }
            }
        }               
    }
}
