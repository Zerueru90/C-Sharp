namespace Klasser
{
    public class Buss : Fordon
    {
        public int Passagerare { get; set; }
        private string _fordonsTyp = "Buss";

        public Buss(string namn, string regnr, string ms, int passagerare)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            Passagerare = passagerare;
        }

        public override string GetFordonsTyp()
        {
            return _fordonsTyp;
        }

        public override string GetSpecialTyp()
        {
            return $"Passagerare: {Passagerare}st";
        }


    }
}
