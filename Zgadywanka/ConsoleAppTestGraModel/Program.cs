using System;
using GraModel;

namespace ConsoleAppTestGraModel
{
    class Program
    {
        static void Main(string[] args)
        {
            var gra = new Gra(1, 60);
            Console.WriteLine( gra );

            do
            {
                Console.Write("Podaj propozycję: ");
                int prop = int.Parse(Console.ReadLine());
                var odp = gra.Ocena(prop);
                Console.WriteLine(odp);
                if (odp == Gra.Odpowiedz.Trafiono)
                    break;                
            }
            while (true);


        }
    }
}
