using System;
using System.Collections.Generic;
using System.Text;

namespace GraProceduralnie
{
    partial class Program
    {

        /// <summary>
        /// Losuje liczbę całkowitą z podanego zakresu włącznie z granicami
        /// </summary>
        /// <remarks>
        /// ...
        /// </remarks>
        /// <example>
        /// 
        /// </example>
        /// <param name="min">dolne ograniczenie przdziału losowania, włącznie</param>
        /// <param name="max">górne ograniczenie przedziału losowania, włącznie</param>
        /// <exception cref="ArgumentException">jesli min > max</exception>
        /// <returns>wylosowana liczba z zakresu min...max</returns>
        static int Losuj(int min, int max)
        {
            var _ = new Random();
            int x = _.Next(min, max + 1);
            return x;
        }

        static int Losuj1(int min, int max) => (new Random()).Next(min, max + 1);

        Func<int, int, int> Losuj3 =   (min, max) => (new Random()).Next(min, max+1); // z uzyciem lambda notacji

        // ===========================


        static int WczytajLiczbe(string komunikat = "Podaj liczbę: ")
        {
            Console.WriteLine(komunikat);
            string napis = Console.ReadLine();
            if(napis == "x" || napis == "X")
            {
                Console.WriteLine("Poddałeś się. Koniec programu");
                Environment.Exit(0);
            }

            int wynik = int.Parse(napis);
            return wynik;
        }


    }
}
