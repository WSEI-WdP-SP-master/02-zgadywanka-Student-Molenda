using System;
using GraModel;

namespace ConsoleAppTestGraModel
{
    class Program
    {
        static void Main(string[] args)
        {
            OpisGry();

            int min = GraMetodyPomocnicze.WczytajLiczbe("Podaj dolną granicę losowania: ") ?? int.MaxValue;
            int max = GraMetodyPomocnicze.WczytajLiczbe("Podaj górną granicę losowania: ") ?? int.MinValue;

            var gra = new Gra(min, max);
            Console.WriteLine( "Wylosowałem liczbę, odgadnij ją" );

            do
            {
                var prop = GraMetodyPomocnicze.WczytajLiczbe("Podaj swoja propozycję (lub X aby poddać): ");
                if( !prop.HasValue ) // is null
                {
                    gra.Poddaj();
                    break;
                }

                var odp = gra.Ocena(prop.Value);

                switch (odp)
                {
                    case Gra.Odpowiedz.ZaMalo:
                        GraMetodyPomocnicze.ColorWriteLine("za mało", ConsoleColor.Red);
                        break;
                    case Gra.Odpowiedz.Trafiono:
                        GraMetodyPomocnicze.ColorWriteLine("TRAFIŁEŚ", ConsoleColor.Green);
                        break;
                    case Gra.Odpowiedz.ZaDuzo:
                        GraMetodyPomocnicze.ColorWriteLine("za duzo", ConsoleColor.Red);
                        break;
                    default:
                        break;
                }

                if (odp == Gra.Odpowiedz.Trafiono)
                    break;                
            }
            while (true);

            foreach( var ruch in gra.ListaRuchow )
            {
                Console.WriteLine(ruch);
            }
            Console.WriteLine($"Czas gry: {gra.CzasGry}");
        }
    
        static void OpisGry()
        {
            Console.WriteLine("Gra w za dużo za mało polega na  ....");
            Console.WriteLine("....");
        }
    
    
    
    }



}
