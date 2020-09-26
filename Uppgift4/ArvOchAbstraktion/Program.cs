using Klasser;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace ArvOchAbstraktion
{
    class Program
    {
        public static StartHumanProgram startHumanProgram { get; set; }
        
        static void Main(string[] args)
        {
            startHumanProgram = new StartHumanProgram();
            //StartaCarProgram startCarProgram = new StartaCarProgram();
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
                        startHumanProgram.Start();
                        //startCarProgram.Start();
                        break;
                    case 2:
                        //Sätt in bilar i vst, interface.
                        StartaVerkstadProgram startaVerkstadProgram = new StartaVerkstadProgram();
                        startaVerkstadProgram.Start();
                        break;
                    case 3:
                        loop = false;
                        Console.WriteLine("Ciao");
                        Console.ReadLine();
                        break;
                    case 4:

                        Console.Write("Skriv namn på bilägaren: ");
                        string sökNamn = Console.ReadLine();
                        SkrivUtPersonOchBil(sökNamn);

                        break;
                    default:
                        break;
                }
            } while (loop);
        }
        public static void SkrivUtPersonOchBil(string namn)
        {
            foreach (var item in startHumanProgram.ListaPersoner)
            {
                if (item.Namn == namn)
                {
                    Console.WriteLine($"Namn: {item.Namn} " +
                                      $"\nÅlder: {item.Ålder}");

                    foreach (var item2 in item.Fordon)
                    {
                        Console.WriteLine("\n-------------------------");
                        Console.WriteLine($"Fordonstyp: {item2.GetFordonsTyp()}" +
                                          $"\nNamn: {item2.Modellnamn} " +
                                          $"\nReg: {item2.Registreringsnummer}" +
                                          $"\nMS: {item2.Mätare}" +
                                          $"\n{item2.GetSpecialTyp()}");
                        Console.WriteLine("-------------------------");
                    }
                }
            }
        }
    }
}
