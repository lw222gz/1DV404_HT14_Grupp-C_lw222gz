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
                try
                {
                    int a;
                    int b;
                    int c;
                    int d;

                    Console.Clear();
                    Fraction fraction = null;
                    Menu();
                    int choice = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (choice)
                    {
                        case 0:
                            return;
                        case 1:
                            a = ReadFractionValue("Ange den första täljaren:");
                            b = ReadFractionValue("Ange den första nämnaren:");
                            c = ReadFractionValue("Ange den andra täljare:");
                            d = ReadFractionValue("Ange den andra nämnaren:");
                            fraction = new Fraction(a, b, c, d);
                            fraction.Add();

                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0}/{1} och {2}/{3}", a, b, c, d);
                            ViewResult(" adderade blir:", fraction);
                            break;
                        case 2:
                            a = ReadFractionValue("Ange den första täljaren:");
                            b = ReadFractionValue("Ange den första nämnaren:");
                            c = ReadFractionValue("Ange den andra täljare:");
                            d = ReadFractionValue("Ange den andra nämnaren:");
                            fraction = new Fraction(a, b, c, d);
                            fraction.Multiply();

                            Console.WriteLine();
                            Console.BackgroundColor = ConsoleColor.DarkBlue;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("{0}/{1} och {2}/{3}", a, b, c, d);
                            ViewResult(" multiplicerade blir:", fraction);
                            break;
                        case 3:
                            a = ReadFractionValue("Ange den första täljaren:");
                            b = ReadFractionValue("Ange den första nämnaren:");
                            c = ReadFractionValue("Ange den andra täljare:");
                            d = ReadFractionValue("Ange den andra nämnaren:");
                            fraction = new Fraction(a, b, c, d);
                            Console.WriteLine();

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
                            break;
                        case 4:
                            a = ReadFractionValue("Ange den första täljaren:");
                            b = ReadFractionValue("Ange den första nämnaren:");
                            fraction = new Fraction(a, b);
                            ViewResult("Aha, vet inte varför men här har du det önsakde bråktalet:", fraction);
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("Du måste ange ett tal emellan 0-4.");
                            Console.ResetColor();
                            break;
                    }
                }
              
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEL! Du får inte skriva in bokstäver SAMT så måste en nämnare vara större än 0.");
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
        static void ViewResult(string prompt, Fraction fraction)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;           
            Console.Write("{0} {1}", prompt, fraction.ToString());
            Console.ResetColor();
            Console.WriteLine();
        }
        
    }
}
