using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartHumanProgram
    {
        private Person _nyPerson;//<<<<<<----------------------------///

        private List<Person> _listaPersoner;

        public List<Person> ListaPersoner
        {
            get
            {
                if (_listaPersoner == null)
                {
                    return _listaPersoner = new List<Person>();
                }
                return _listaPersoner;
            }
            set
            {
                _listaPersoner = value;
            }
        }

        public void Start()
        {
            Console.WriteLine("Vill du mata in egna värden eller låta programmet skapa en massa data?");
            Console.WriteLine("Egen inmatning: [1]");
            Console.WriteLine("Dummy data: [2]");
            Console.Write("Val: ");
            int val = int.Parse(Console.ReadLine());

            switch (val)
            {
                case 1:
                    if (_listaPersoner != null)
                    {
                        _listaPersoner.Clear();
                    }
                    string namn;
                    int ålder;

                    Console.Write("\nNamn: ");
                    namn = Console.ReadLine();

                    Console.Write("Ålder: ");
                    ålder = int.Parse(Console.ReadLine());

                    _nyPerson = new Person();
                    _nyPerson.Namn = namn;
                    _nyPerson.Ålder = ålder;

                    StartaCarProgram startCarProgram = new StartaCarProgram();
                    startCarProgram.BilÄgare = _nyPerson;//<<<<<<----------------------------///
                    startCarProgram.Start();

                    break;
                case 2:
                    //DummyData.StartHumanProgram.ListaPersoner = ListaPersoner;
                    //_nyPerson = DummyData.LoadDummiesToList();
                    break;

                default:
                    break;
            }

            ListaPersoner.Add(_nyPerson);
        }
    }
}
