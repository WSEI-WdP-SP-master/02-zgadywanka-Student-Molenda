using System;
using System.Collections.Generic;
using System.Text;

namespace GraModel
{
    public readonly struct Ruch
    {
        public readonly int? propozycja;
        public readonly Gra.Odpowiedz? odpowiedz;
        public readonly Gra.Stan stanGry;
        public readonly DateTime kiedy;

        public Ruch(int? propozycja, Gra.Odpowiedz? odpowiedz, Gra.Stan stanGry)
        {
            this.propozycja = propozycja;
            this.odpowiedz = odpowiedz;
            this.stanGry = stanGry;
            this.kiedy = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{propozycja} {odpowiedz} {stanGry} {kiedy}";
        }
    }
}
