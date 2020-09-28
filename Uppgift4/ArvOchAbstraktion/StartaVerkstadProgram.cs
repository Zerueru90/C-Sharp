using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartaVerkstadProgram
    {
        public StartHumanProgram StartHumanProgram { get; set; }

        private static IVerkstad _skickaBilTillOchFrånVerkstad;
        private string _regNr;
        private Fordon _fordonObj;

        public void Start()
        {
            bool loopVerkstad = true;
            do
            {
                _skickaBilTillOchFrånVerkstad = new Verkstad();

                Console.WriteLine("\nVällkommen till verkstaden");
                Console.Write("Vad är ditt namn: ");
                string kundNamn = Console.ReadLine();
                SkrivUtFunktion.StartHumanProgram = StartHumanProgram;
                SkrivUtFunktion.SkrivUtPersonOchBil(kundNamn);

                Console.WriteLine("\nSkicka fordonet till verkstad: [1]");
                Console.WriteLine("Hämta ditt fordon från verkstad: [2]");
                Console.WriteLine("Avsluta: [3]");
                Console.Write("Val: ");
                int verkstadVal = int.Parse(Console.ReadLine());

                Console.Write("Skriv in regnr: ");
                _regNr = Console.ReadLine();
                _fordonObj = LetaEfterBil(_regNr);

                switch (verkstadVal)
                {
                    case 1:
                        _skickaBilTillOchFrånVerkstad.LäggtillFordon(_fordonObj);
                        _fordonObj.SetFordonIVerkstadStatus(true);
                        break;
                    case 2:
                        _skickaBilTillOchFrånVerkstad.TabortFordon(_fordonObj, _regNr);
                        _fordonObj.SetFordonIVerkstadStatus(false);
                        break;
                    case 3:
                        loopVerkstad = false;
                        break;
                    default:
                        break;
                }

            } while (loopVerkstad);
        }

        private Fordon LetaEfterBil(string registreringsnummer)
        {
            foreach (var item in StartHumanProgram.ListaPersoner)
            {
                foreach (var item2 in item.Fordon)
                {
                    if (item2.Registreringsnummer == registreringsnummer)
                    {
                        return item2;
                    }
                    else
                        Console.WriteLine("Bilen finns inte");
                }
            }
            return null;
        }
    }
}
