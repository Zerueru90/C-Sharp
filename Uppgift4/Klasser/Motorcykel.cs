namespace Klasser
{
    public class Motorcykel : Fordon
    {
        public int Maxfart { get; set; }

        public bool FordonIVerkstadStatus { get; set; }

        private string _fordonsTyp = "Motorcykel";


        public Motorcykel(string namn, string regnr, string ms, int maxfart)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            Maxfart = maxfart;
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
            return $"Maxfart: {Maxfart}km/h";
        }
    }
}
