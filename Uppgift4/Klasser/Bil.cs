using System.Globalization;

namespace Klasser
{
    public class Bil : Fordon
    {
        public bool Dragkrok { get; set; }

        public bool FordonIVerkstadStatus { get; set; }

        private string _fordonsTyp = "Bil";

        public Bil(string namn, string regnr, string ms, string dragkrock)
        {
            Modellnamn = namn;
            Registreringsnummer = regnr;
            Mätare = ms;
            SetHook(dragkrock);
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
            if (Dragkrok)
            {
                return $"Dragkrock: Ja";
            }
            return $"Dragkrock: Nej";
        }
    }
}
