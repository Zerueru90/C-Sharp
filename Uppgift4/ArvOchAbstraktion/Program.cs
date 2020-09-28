using Klasser;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ArvOchAbstraktion
{
    class Program
    {
        public static StartHumanProgram StartHumanProgram { get; set; }

        private static StartaVerkstadProgram startaVerkstadProgram;

        static void Main(string[] args)
        {
            StartHumanProgram = new StartHumanProgram();
            startaVerkstadProgram = new StartaVerkstadProgram();
            bool loop = true;

            Console.WriteLine("Vällkommen till Fordon programmet");
            do
            {
                Console.WriteLine("\nRegistrera ny ägare: [1]");
                Console.WriteLine("Skicka bilar till verkstad: [2]");
                Console.WriteLine("Avsluta program: [3]");
                Console.WriteLine("Skriv ut bilar: [4]");
                Console.Write("Val: ");
                int val = int.Parse(Console.ReadLine());
                switch (val)
                {
                    case 1:
                        StartHumanProgram.Start();
                        break;
                    case 2:
                        startaVerkstadProgram.StartHumanProgram = StartHumanProgram;
                        startaVerkstadProgram.Start();
                        //IVerkstad vst;
                        //vst = new Verkstad();

                        break;
                    case 3:
                        loop = false;
                        Console.WriteLine("Ciao");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.Write("Skriv namn på bilägaren: ");
                        string sökNamn = Console.ReadLine();
                        SkrivUtFunktion.StartHumanProgram = StartHumanProgram;
                        SkrivUtFunktion.SkrivUtPersonOchBil(sökNamn);
                        break;
                    default:
                        break;
                }
            } while (loop);
        }
    }
}
