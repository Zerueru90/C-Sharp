using Klasser;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ArvOchAbstraktion
{
    class Program
    {
        private static StartHumanProgram StartHumanProgram;

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
                int val = FelhanteringKlass.SwitchLimit("Val: ", 4);
                switch (val)
                {
                    case 1:
                        StartHumanProgram.Start();
                        break;
                    case 2:
                        startaVerkstadProgram.Start();
                        break;
                    case 3:
                        loop = false;
                        Console.WriteLine("Ciao");
                        Console.ReadLine();
                        break;
                    case 4:
                        string sökNamn = FelhanteringKlass.ReturnText("Skriv namn på bilägaren: ");
                        SkrivUtFunktion.SkrivUtPersonOchBil(sökNamn);
                        break;
                    default:
                        break;
                }
            } while (loop);
        }
    }
}
