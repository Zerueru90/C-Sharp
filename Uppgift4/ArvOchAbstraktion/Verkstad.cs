using Klasser;
using System.Collections.Generic;

namespace ArvOchAbstraktion
{
    public class Verkstad : IVerkstad
    {
        private List<Fordon> _fordonIVerkstad;

        public List<Fordon> FordonIVerkstad
        {
            get
            {
                if (_fordonIVerkstad == null)
                {
                    return _fordonIVerkstad = new List<Fordon>();
                }
                return _fordonIVerkstad;
            }
            set
            {
                _fordonIVerkstad = value;
            }
        }

        public void LäggtillFordon(Fordon fordon)
        {
            FordonIVerkstad.Add(fordon);
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("Fordon skickad till verkstad");
            System.Console.WriteLine("-----------------------------");
        }
        public void TabortFordon(Fordon fordon, string regnr)
        {
            foreach (var item in FordonIVerkstad)
            {
                if (item.Registreringsnummer == regnr)
                {
                    FordonIVerkstad.Remove(fordon);
                    System.Console.WriteLine("-----------------------------");
                    System.Console.WriteLine("Fordon borttagen ifrån verkstad");
                    System.Console.WriteLine("-----------------------------");
                }
            }
        }
    }
}
