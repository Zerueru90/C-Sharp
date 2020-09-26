namespace Klasser
{
    public class Bil : Fordon
    {
        public bool Dragkrok { get; set; }

        private string _fordonsTyp = "Bil";

        public Bil(string namn, string regnr, string ms, string dragkrock)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            SetHook(dragkrock);
        }

        public override string GetFordonsTyp()
        {
            return _fordonsTyp;
        }

        public bool SetHook(string dragkrok)
        {
            if (dragkrok == "y")
            {
                return Dragkrok = true;
            }
                return Dragkrok = false;
        }

        public override string GetSpecialTyp()
        {
            return $"Dragkrock: {Dragkrok}";
        }

    }
}
