using System;

namespace GraMonolitycznie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gra w Za duzo za mało!");

            #region 1. Koputer losuje
            var los = new Random();
            int wylosowana = los.Next(1, 101); // losujemy z zakresu od 1 do 100

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
                if( ! int.TryParse(napis, out propozycja) )
                {
                    Console.WriteLine("Nie podałeś poprawnej liczby.\n Spróbuj raz jeszcze.");
                    continue;
                }

                Console.WriteLine($"Zaproponowałeś: {propozycja}");

                #endregion

                #region 3. Komputer ocenia propozycję
                if (propozycja < wylosowana)
                {
                    Console.WriteLine("Za mało");
                }
                else if (propozycja > wylosowana)
                {
                    Console.WriteLine("Za dużo");
                }
                else
                {
                    Console.WriteLine("Trafiono");
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
