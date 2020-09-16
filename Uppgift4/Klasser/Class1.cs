using System;

namespace Klasser
{
    public class Bil 
    {
        public string Modellnamn { get; set; }
        public string Registreringsnummer { get; set; }
        public string Mätare { get; set; }
        public string Registreringsdatum { get; set; }

        private bool Dragkrok { get; set; }


    }
    public class Motorcykel : Bil
    {
        public int Maxfart { get; set; }

        

    }
    public class Buss : Bil
    {
        public int Passagerare { get; set; }

        
    }
    public class Lastbil : Bil
    {
        public int Maxlast { get; set; }


    }
}
