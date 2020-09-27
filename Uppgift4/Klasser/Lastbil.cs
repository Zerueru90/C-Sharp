namespace Klasser
{
    public class Lastbil : Fordon
    {
        public int Maxlast { get; set; }
        public bool FordonIVerkstadStatus { get; set; }

        private string _fordonsTyp = "Lastbil";

        public Lastbil(string namn, string regnr, string ms, int maxlast)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            Maxlast = maxlast;
        }

        public override bool SetFordonIVerkstadStatus(bool status)
        {
            if (status)
            {
                return FordonIVerkstadStatus = true;
            }
            return FordonIVerkstadStatus = false;
        }

        public override string GetFordonIVerkstadStatus()
        {
            if (FordonIVerkstadStatus)
            {
                return $"**OBS** Denna fordon är i verkstad";
            }
            return $" ";
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
