namespace Klasser
{
    public class Motorcykel : Fordon
    {
        public int Maxfart { get; set; }

        private string _fordonsTyp = "Motorcykel";


        public Motorcykel(string namn, string regnr, string ms, int maxfart)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            Maxfart = maxfart;
        }
        public override string GetFordonsTyp()
        {
            return _fordonsTyp;
        }

        public override string GetSpecialTyp()
        {
            return $"Maxfart: {Maxfart}km/h";
        }
    }
}
