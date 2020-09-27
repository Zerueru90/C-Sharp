using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartaVerkstadProgram
    {
        public StartHumanProgram startHumanProgram { get; set; }

        public static Verkstad SkickaBilTillOchFrånVerkstad { get; set; }

        public void Start()
        {
            bool loopVerkstad = true;
            do
            {
                SkickaBilTillOchFrånVerkstad = new Verkstad();

                Console.WriteLine("\nVällkommen till verkstaden");
                Console.Write("Vad är ditt namn: ");
                string kundNamn = Console.ReadLine();
                SkrivUtKundsFordon(kundNamn);

                Console.WriteLine("\nSkicka fordonet till verkstad: [1]");
                Console.WriteLine("Hämta ditt fordon från verkstad: [2]");
                Console.WriteLine("Klar: [3]");
                Console.Write("Val: ");
                int verkstadVal = int.Parse(Console.ReadLine());

                switch (verkstadVal)
                {
                    case 1:
                        Console.Write("Skriv in regnr: ");
                        string regnr = Console.ReadLine();
                        var obj = LetaEfterBil(regnr);
                        SkickaBilTillOchFrånVerkstad.läggtillFordon(obj);
                        obj.SetFordonIVerkstadStatus(true);
                        break;
                    case 2:
                        Console.Write("Skriv in regnr: ");
                        string regnrTabort = Console.ReadLine();
                        var objTabort = LetaEfterBil(regnrTabort);
                        SkickaBilTillOchFrånVerkstad.tabortFordon(objTabort, regnrTabort);
                        objTabort.SetFordonIVerkstadStatus(false);
                        break;
                    case 3:
                        loopVerkstad = false;
                        break;
                    default:
                        break;
                }

            } while (loopVerkstad);
        }

        private void SkrivUtKundsFordon(string kundNamn)
        {
            foreach (var item in startHumanProgram.ListaPersoner)
            {
                if (kundNamn == item.Namn)
                {
                    Program.SkrivUtPersonOchBil(item.Namn);
                }
            }
        }

        private Fordon LetaEfterBil(string regnr)
        {
            foreach (var item in startHumanProgram.ListaPersoner)
            {
                foreach (var item2 in item.Fordon)
                {
                    if (item2.Registreringsnummer == regnr)
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
