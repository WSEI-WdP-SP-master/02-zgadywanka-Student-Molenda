using System;
using System.Collections.Generic;

namespace GraModel
{
    public class Gra
    {
        private readonly int liczbaOdgadywana;

        public int Min { get; private set; }
        public int Max { get; private set; }

        public enum Stan { Trwa, Poddana, Zakonczona }
        public Stan StanGry { get; private set; }

        // historia ruchów
        public readonly List<Ruch> ListaRuchow;

        public TimeSpan CzasGry =>  ListaRuchow[ListaRuchow.Count - 1].kiedy - ListaRuchow[0].kiedy;

        // ctor's

        /// <summary>
        /// 
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <exception cref="ArgumentException">jeśli min > max</exception>
        public Gra(int min, int max)
        {
            this.Min = min;
            Max = max;
            liczbaOdgadywana = (new Random()).Next(min, max + 1);
            StanGry = Stan.Trwa;
            ListaRuchow = new List<Ruch>();
            ListaRuchow.Add(new Ruch(propozycja: null, odpowiedz: null, StanGry));
        }

        public Gra(): this(1,100) {  }

        // inne metody

        public override string ToString()
        {
#if DEBUG
            return $"min={Min}, max={Max}, do odgadnięcia={liczbaOdgadywana}";
#else
            return base.ToSting();
#endif
        }


        public enum Odpowiedz { ZaMalo = -1, Trafiono = 0, ZaDuzo = 1 }

        public Odpowiedz Ocena(int propozycja)
        {
            if( propozycja < liczbaOdgadywana )
            {
                ListaRuchow.Add(new Ruch(propozycja, Odpowiedz.ZaMalo, StanGry));
                return Odpowiedz.ZaMalo;
            }
            else if( propozycja > liczbaOdgadywana )
            {
                ListaRuchow.Add(new Ruch(propozycja, Odpowiedz.ZaDuzo, StanGry));
                return Odpowiedz.ZaDuzo;
            }
            else
            {
                StanGry = Stan.Zakonczona;
                ListaRuchow.Add(new Ruch(propozycja, Odpowiedz.ZaDuzo, StanGry));
                return Odpowiedz.Trafiono;
            }
        }

        public int Poddaj()
        {
            StanGry = Stan.Poddana;
            ListaRuchow.Add(new Ruch(propozycja: null, odpowiedz: null, StanGry));
            return liczbaOdgadywana;
        }

    }
}
