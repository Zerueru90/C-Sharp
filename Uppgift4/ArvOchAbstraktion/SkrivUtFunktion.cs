using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    static class SkrivUtFunktion
    {
        public static void SkrivUtPersonOchBil(string namn)
        {
            if (FelhanteringKlass.CheckListEmpty(KlassLista<Person>.GeneriskLista.Count))
            {
                foreach (var item in KlassLista<Person>.GeneriskLista)
                {
                    if (item.Namn == namn)
                    {

                        Console.WriteLine("\n-------------------------");
                        Console.WriteLine($"\nNamn: {item.Namn} " +
                                          $"\nÅlder: {item.Ålder}");

                        foreach (var item2 in item.Fordon)
                        {
                            Console.WriteLine("\n-------------------------");
                            Console.WriteLine($"Fordonstyp: {item2.GetFordonsTyp()}" +
                                              $"\nNamn: {item2.Modellnamn} " +
                                              $"\nReg: {item2.Registreringsnummer}" +
                                              $"\nMS: {item2.Mätare}" +
                                              $"\n{item2.GetSpecialTyp()}" +
                                              $"\n{item2.GetFordonIVerkstadStatus()}");
                            Console.WriteLine("-------------------------");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nTomt");
            }
        }
    }
}
