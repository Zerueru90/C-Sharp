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

        /*
         Fråga användaren om namn
         Skriv ut lista av personens bilar.
         Sen starta Start() så att kund kan använda listan för att skriva in reg nr
         */

        public void Start()
        {
            bool loopVerkstad = true;
            do
            {
                Console.WriteLine("\nVällkommen till verkstaden");
                Console.Write("Vad är ditt namn: ");
                string kundNamn = Console.ReadLine();
                HämtaPersonFordon(kundNamn);

                Console.WriteLine("\nSkicka in bilen till verkstad: [1]");
                Console.WriteLine("Hämta bilen från verkstad: [2]");
                Console.WriteLine("Klar: [3]");
                Console.Write("Val: ");
                int verkstadVal = int.Parse(Console.ReadLine());

                switch (verkstadVal)
                {
                    case 1:
                        Console.Write("Skriv in regnr: ");
                        string regnr = Console.ReadLine();
                        var obj = LetaEfterBil(regnr);
                        SkickaBilTillOchFrånVerkstad = new Verkstad();
                        SkickaBilTillOchFrånVerkstad.läggtillFordon(obj);
                        break;
                    case 2:
                        Console.Write("Skriv in regnr: ");
                        string regnrTabort = Console.ReadLine();
                        var objTabort = LetaEfterBil(regnrTabort);
                        SkickaBilTillOchFrånVerkstad = new Verkstad();
                        SkickaBilTillOchFrånVerkstad.tabortFordon(objTabort, regnrTabort);
                        break;
                    case 3:
                        loopVerkstad = false;
                        break;
                    default:
                        break;
                }

            } while (loopVerkstad);
        }

        public void HämtaPersonFordon(string kundNamn)
        {
            foreach (var item in startHumanProgram.ListaPersoner)
            {
                if (kundNamn == item.Namn)
                {
                    Program.SkrivUtPersonOchBil(item.Namn);
                }
            }
        }

        public Fordon LetaEfterBil(string regnr)
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
