using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartHumanProgram
    {
        private Person _nyPerson;

        public void Start()
        {
            Console.WriteLine("Vill du mata in egna värden eller låta programmet skapa en massa data?");
            Console.WriteLine("Egen inmatning: [1]");
            Console.WriteLine("Dummy data: [2]");
            int val = FelhanteringKlass.SwitchLimit("Val: ", 2);

            switch (val)
            {
                case 1:
                    string namn;
                    int ålder;
                    StartaCarProgram startCarProgram;
                    _nyPerson = new Person();

                    namn = FelhanteringKlass.ReturnText("\nNamn: "); 
                    ålder = FelhanteringKlass.ReturnNumber("Ålder: ");

                    _nyPerson.Namn = namn;
                    _nyPerson.Ålder = ålder;

                    startCarProgram = new StartaCarProgram();
                    startCarProgram.BilÄgare = _nyPerson;
                    startCarProgram.Start();

                    KlassLista<Person>.GeneriskLista.Add(_nyPerson);

                    break;
                case 2:
                    DummyData.LoadDummiesToList();
                    break;

                default:
                    break;
            }
        }
    }
}
