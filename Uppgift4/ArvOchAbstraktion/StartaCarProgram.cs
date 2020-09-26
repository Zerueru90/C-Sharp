using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartaCarProgram
    {
        Klasser.Bil bil;
        Klasser.Motorcykel mc;
        Klasser.Buss buss;
        Klasser.Lastbil lb;
        public string BilModellNamn { get; set; }
        public string Registreringsnummer { get; set; }
        public string Mätare { get; set; }

        public Person BilÄgare { get; set; } //Sättar jag från StartHumanProgram så att jag inte behöver instansiera en BilÄgare = new Person();

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
                        bil = new Klasser.Bil(BilModellNamn, Mätare, Registreringsnummer, svarDragKrock);

                        BilÄgare.Fordon.Add(bil);
                        break;
                    case 2:
                        SkrivIn();
                        Console.Write("Vad är maxfarten för MC: ");
                        int svarMC = int.Parse(Console.ReadLine());
                        mc = new Klasser.Motorcykel(BilModellNamn, Mätare, Registreringsnummer, svarMC);

                        BilÄgare.Fordon.Add(mc);
                        break;
                    case 3:
                        SkrivIn();
                        Console.Write("Hur många passagerare?: ");
                        int svarBuss = int.Parse(Console.ReadLine());
                        buss = new Klasser.Buss(BilModellNamn, Mätare, Registreringsnummer, svarBuss);

                        BilÄgare.Fordon.Add(buss);
                        break;
                    case 4:
                        SkrivIn();
                        Console.Write("Vad är maxlasten?: ");
                        int svarLB = int.Parse(Console.ReadLine());
                        lb = new Klasser.Lastbil(BilModellNamn, Mätare, Registreringsnummer, svarLB);

                        BilÄgare.Fordon.Add(lb);
                        break;
                    case 5:
                        loop = false;
                        break;
                    default:
                        break;
                }

            } while (loop);
        }

        public void SkrivIn()
        {
            Console.Write("Modellnamn: ");
            BilModellNamn = Console.ReadLine();
            Console.Write("Registreringsnummer: ");
            Registreringsnummer = Console.ReadLine();
            Console.Write("Mätarställning: ");
            Mätare = Console.ReadLine();
        }
    }
}
