using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public abstract class Fordon
    {
        public string Modellnamn { get; set; }
        public string Registreringsnummer { get; set; }
        public string Mätare { get; set; }

        public abstract string GetSpecialTyp();

        public abstract string GetFordonsTyp();
    }
}
