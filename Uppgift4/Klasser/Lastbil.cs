namespace Klasser
{
    public class Lastbil : Fordon
    {
        public int Maxlast { get; set; }

        private string _fordonsTyp = "Lastbil";

        public Lastbil(string namn, string regnr, string ms, int maxlast)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            Maxlast = maxlast;
        }

        public override string GetFordonsTyp()
        {
            return _fordonsTyp;
        }

        public override string GetSpecialTyp()
        {
            return $"Maxlast: {Maxlast}kg";
        }
    }
}
