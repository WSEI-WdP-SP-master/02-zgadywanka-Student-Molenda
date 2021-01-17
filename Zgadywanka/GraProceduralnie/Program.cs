using System;

namespace GraProceduralnie
{
    partial class Program
    {
        const string ZA_DUZO = "Za dużo";
        const string ZA_MALO = "Za mało";
        const string TRAFIONO = "Trafiono";

        static void Main(string[] args)
        {
            Console.WriteLine("Gra w Za duzo za mało!");

            #region 1. Koputer losuje
            int wylosowana = Losuj(1, 100);

#if DEBUG
            Console.WriteLine(wylosowana);  // do usunięcia w ostatecznej wersji kodu
#endif

            Console.WriteLine("Wylosowałem liczbę od 1 do 100.\n Odgadnij ją!");
            #endregion

            do
            {
                int propozycja = WczytajLiczbe("Podaj swoją propozycję (lub X aby zakończyć): ");

                if (propozycja < wylosowana)
                {
                    ColorWriteLine(ZA_MALO, ConsoleColor.Red);
                }
                else if (propozycja > wylosowana)
                {
                    ColorWriteLine(ZA_DUZO, ConsoleColor.Red);
                }
                else
                {
                    ColorWriteLine(TRAFIONO, ConsoleColor.Green);
                    break;
                }
            }
            while (true);

            Console.WriteLine("Koniec gry");
        }
    }
}
