using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartaCarProgram
    {
        public Person BilÄgare { get; set; }//<<<<<<----------------------------///

        private Fordon _fordon;
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
                        _fordon = new Bil(_bilModellNamn, _mätare, _registreringsnummer, svarDragKrock);
                        BilÄgare.Fordon.Add(_fordon);

                        break;
                    case 2:

                        SkrivIn();
                        Console.Write("Vad är maxfarten för MC: ");
                        int svarMC = int.Parse(Console.ReadLine());
                        _fordon = new Motorcykel(_bilModellNamn, _mätare, _registreringsnummer, svarMC);
                        BilÄgare.Fordon.Add(_fordon);

                        break;
                    case 3:

                        SkrivIn();
                        Console.Write("Hur många passagerare?: ");
                        int svarBuss = int.Parse(Console.ReadLine());
                        _fordon = new Buss(_bilModellNamn, _mätare, _registreringsnummer, svarBuss);
                        BilÄgare.Fordon.Add(_fordon);

                        break;
                    case 4:

                        SkrivIn();
                        Console.Write("Vad är maxlasten?: ");
                        int svarLB = int.Parse(Console.ReadLine());
                        _fordon = new Lastbil(_bilModellNamn, _mätare, _registreringsnummer, svarLB);
                        BilÄgare.Fordon.Add(_fordon);

                        break;
                    case 5:
                        loop = false;
                        break;
                    default:
                        break;
                }

            } while (loop);
        }

        /// <summary>
        /// Kanske kan skicka denna metod till varje bil, buss, mc osv klass så kan vi ta bort konstruktorn.
        /// </summary>
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
