using Klasser;
using System.Collections.Generic;

namespace ArvOchAbstraktion
{
    public class Verkstad : IVerkstad
    {
        List<Fordon> _fordonIVerkstad { get; set; }

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

        public void läggtillFordon(Fordon fordon)
        {
            FordonIVerkstad.Add(fordon);
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("Fordon inlagd i verkstad");
            System.Console.WriteLine("-----------------------------");
        }
        public void tabortFordon(Fordon fordon, string regnr)
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
