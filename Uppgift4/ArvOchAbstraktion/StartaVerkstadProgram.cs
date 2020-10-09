using Klasser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartaVerkstadProgram
    {
        private Verkstad _skickaBilTillOchFrånVerkstad { get; set; }
        private string _regNr;
        string kundNamn;
        private Fordon _fordonObj;

        public void Start()
        {
            _skickaBilTillOchFrånVerkstad = new Verkstad();

            if (FelhanteringKlass.CheckListEmpty(KlassLista<Person>.GeneriskLista.Count))
            {
                Console.WriteLine("\nVällkommen till verkstaden");

                bool loopVerkstad = true;
                do
                {
                    SkrivUtFunktion.SkrivUtPersonOchBil(kundNamn = FelhanteringKlass.ReturnText("\nNamn: "));
                    Console.WriteLine("\nSkicka fordonet till verkstad: [1]");
                    Console.WriteLine("Hämta ditt fordon från verkstad: [2]");
                    Console.WriteLine("Avsluta: [3]");
                    int verkstadsVal = FelhanteringKlass.SwitchLimit("Val: ", 3);

                    switch (verkstadsVal)
                    {
                        case 1:
                            LetaEfterBil();
                            _skickaBilTillOchFrånVerkstad.LäggtillFordon(_fordonObj);
                            _fordonObj.SetFordonIVerkstadStatus(true);
                            break;
                        case 2:
                            LetaEfterBil();
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
            else
            {
                Console.WriteLine("\nInga fordon i garaget");
            }
        }
        private void LetaEfterBil()
        {
            _regNr = FelhanteringKlass.ReturnText("\nReg nr: ");

            foreach (var item in KlassLista<Person>.GeneriskLista)
            {
                if (item.Namn == kundNamn) //Lika gärna göra personnummer vilket är unikt för varje person //Men i denna värld existerar bara en pers = ett namn.
                {
                    foreach (var item2 in item.Fordon)
                    {
                        if (item2.Registreringsnummer == _regNr)
                        {
                            _fordonObj = item2;
                        }
                    }
                }

                if (_fordonObj == null)
                {
                    Console.WriteLine("Fel reg nr");
                    Start();
                }
            }
        }
    }
}
