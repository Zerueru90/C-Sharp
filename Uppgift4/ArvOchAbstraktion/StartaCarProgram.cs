using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartaCarProgram
    {
        public Person BilÄgare { get; set; }
         
        private string _bilModellNamn;
        private string _registreringsnummer;
        private int _mätare;
        private int _specialTyp;

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
                int val = FelhanteringKlass.SwitchLimit("Val: ", 5);

                switch (val)
                {
                    case 1:
                        SkrivIn();
                        string svarDragKrock = FelhanteringKlass.ReturnOnlyYesOrNo("Har bilen dragkrock? y/n: ");
                        BilÄgare.Fordon.Add(new Bil(_bilModellNamn, _registreringsnummer, _mätare, svarDragKrock));

                        break;
                    case 2: 
                        SkrivIn();
                        _specialTyp = FelhanteringKlass.ReturnNumber("Vad är maxfarten för MC: ");
                        BilÄgare.Fordon.Add(new Motorcykel(_bilModellNamn, _registreringsnummer, _mätare,  _specialTyp));

                        break;
                    case 3: 
                        SkrivIn();
                        _specialTyp = FelhanteringKlass.ReturnNumber("Hur många passagerare?: "); 
                        BilÄgare.Fordon.Add(new Buss(_bilModellNamn, _registreringsnummer, _mätare, _specialTyp));
                        break;

                    case 4: 
                        SkrivIn();
                        _specialTyp = FelhanteringKlass.ReturnNumber("Vad är maxlasten?: "); 
                        BilÄgare.Fordon.Add(new Lastbil(_bilModellNamn, _registreringsnummer, _mätare, _specialTyp));
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
            _bilModellNamn = FelhanteringKlass.ReturnText("Modellnamn: "); 
            _registreringsnummer = FelhanteringKlass.ReturnText("Registreringsnummer: ");
            _mätare = FelhanteringKlass.ReturnNumber("Mätarställning: "); 
        }
    }
}
