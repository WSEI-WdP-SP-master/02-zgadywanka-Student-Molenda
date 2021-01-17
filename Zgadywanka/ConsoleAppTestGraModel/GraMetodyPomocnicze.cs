using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppTestGraModel
{
    public static class GraMetodyPomocnicze
    {
        public static void ColorWrite(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }

        public static void ColorWriteLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        public static int? WczytajLiczbe(string komunikat = "Podaj liczbę (lub X aby zakończyć): ")
        {
            do
            {
                Console.Write(komunikat);
                string napis = Console.ReadLine();
                if (napis.Trim().ToUpper() == "X")      //(napis == "x" || napis == "X")
                {
                    Console.WriteLine("Poddałeś się. Koniec programu");
                    return null;
                }

                if (int.TryParse(napis, out int wynik))
                {
                    return wynik;
                }
                else
                {
                    Console.WriteLine("Nie podałeś liczby całkowitej, spróbuj raz jeszcze.");
                }
            }
            while (true);
        }
    }
}
