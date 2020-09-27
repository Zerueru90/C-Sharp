using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartaCarProgram
    {
        public Person BilÄgare { get; set; }

        private Klasser.Bil _bil;
        private Klasser.Motorcykel _mc;
        private Klasser.Buss _buss;
        private Klasser.Lastbil _lb;

        private string _bilModellNamn;
        private string _registreringsnummer;
        private string _mätare;

        public void Start()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("\nVälj vilken typ av fordon du vill registrera");
                Console.WriteLine("Bil [1]");
                Console.WriteLine("Motorcykel [2]");
                Console.WriteLine("Buss [3]");
                Console.WriteLine("Lastbil [4]");
                Console.WriteLine("Avsluta [5]");
                Console.Write("\nVal: ");
                int val = int.Parse(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        SkrivIn();
                        Console.Write("Har bilen dragkrock? y/n: ");
                        string svarDragKrock = Console.ReadLine();
                        _bil = new Klasser.Bil(_bilModellNamn, _mätare, _registreringsnummer, svarDragKrock);

                        BilÄgare.Fordon.Add(_bil);
                        break;
                    case 2:
                        SkrivIn();
                        Console.Write("Vad är maxfarten för MC: ");
                        int svarMC = int.Parse(Console.ReadLine());
                        _mc = new Klasser.Motorcykel(_bilModellNamn, _mätare, _registreringsnummer, svarMC);

                        BilÄgare.Fordon.Add(_mc);
                        break;
                    case 3:
                        SkrivIn();
                        Console.Write("Hur många passagerare?: ");
                        int svarBuss = int.Parse(Console.ReadLine());
                        _buss = new Klasser.Buss(_bilModellNamn, _mätare, _registreringsnummer, svarBuss);

                        BilÄgare.Fordon.Add(_buss);
                        break;
                    case 4:
                        SkrivIn();
                        Console.Write("Vad är maxlasten?: ");
                        int svarLB = int.Parse(Console.ReadLine());
                        _lb = new Klasser.Lastbil(_bilModellNamn, _mätare, _registreringsnummer, svarLB);

                        BilÄgare.Fordon.Add(_lb);
                        break;
                    case 5:
                        loop = false;
                        break;
                    default:
                        break;
                }

            } while (loop);
        }

        private void SkrivIn()
        {
            Console.Write("Modellnamn: ");
            _bilModellNamn = Console.ReadLine();
            Console.Write("Registreringsnummer: ");
            _registreringsnummer = Console.ReadLine();
            Console.Write("Mätarställning: ");
            _mätare = Console.ReadLine();
        }
    }
}
