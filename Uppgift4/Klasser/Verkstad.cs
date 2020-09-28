using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Verkstad : IVerkstad
    {
        private List<Fordon> _fordonIGarage;

        public List<Fordon> FordonIGarage
        {
            get
            {
                if (_fordonIGarage == null)
                {
                    return _fordonIGarage = new List<Fordon>();
                }
                return _fordonIGarage;
            }
            set
            {
                _fordonIGarage = value;
            }
        }

        public void LäggtillFordon(Fordon fordon)
        {
            FordonIGarage.Add(fordon);
            System.Console.WriteLine("-----------------------------");
            System.Console.WriteLine("Fordon skickad till verkstad");
            System.Console.WriteLine("-----------------------------");
        }
        public void TabortFordon(Fordon fordon, string regnr)
        {
            //IF FordinIGarage.Count() == 0 --> Garage is empty
            foreach (var item in FordonIGarage)
            {
                if (item.Registreringsnummer == regnr)
                {
                    FordonIGarage.Remove(fordon);
                    System.Console.WriteLine("-----------------------------");
                    System.Console.WriteLine("Fordon borttagen ifrån verkstad");
                    System.Console.WriteLine("-----------------------------");
                    return;
                }
            }
        }
    }
}
