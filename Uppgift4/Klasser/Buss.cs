namespace Klasser
{
    public class Buss : Fordon
    {
        public int Passagerare { get; set; }
        public bool FordonIVerkstadStatus { get; set; }
        private string _fordonsTyp = "Buss";

        public Buss(string namn, string regnr, string ms, int passagerare)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            Passagerare = passagerare;
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
            return $"Passagerare: {Passagerare}st";
        }


    }
}
