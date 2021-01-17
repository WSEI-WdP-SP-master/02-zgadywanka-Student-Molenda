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

            //POWTARZAJ AŻ Do ZGADNIĘCIA

            //bool trafiono = false;
            do
            {
                #region 2. Człowiek proponuje
                Console.Write("Podaj swoja propozycję: ");
                string napis = Console.ReadLine();

                int propozycja;
                if (!int.TryParse(napis, out propozycja))
                {
                    Console.WriteLine("Nie podałeś poprawnej liczby.\n Spróbuj raz jeszcze.");
                    continue;
                }

                Console.WriteLine($"Zaproponowałeś: {propozycja}");

                #endregion

                #region 3. Komputer ocenia propozycję
                if (propozycja < wylosowana)
                {
                    Console.WriteLine(ZA_MALO);
                }
                else if (propozycja > wylosowana)
                {
                    Console.WriteLine(ZA_DUZO);
                }
                else
                {
                    Console.WriteLine(TRAFIONO);
                    break; //trafiono = true;
                }

                #endregion
            }
            while (true); //while (!trafiono);
                          //KONIEC POWTARZANIA

            Console.WriteLine("Koniec gry");
        }
    



    }
}
