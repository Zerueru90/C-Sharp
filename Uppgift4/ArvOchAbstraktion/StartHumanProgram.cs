using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartHumanProgram
    {
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
        private Person nyPerson { get; set; }

        public void Start()
        {
            string namn;
            int ålder;

            Console.Write("\nNamn: ");
            namn = Console.ReadLine();

            Console.Write("Ålder: ");
            ålder = int.Parse(Console.ReadLine());

            nyPerson = new Person();
            nyPerson.Namn = namn;
            nyPerson.Ålder = ålder;

            StartaCarProgram startCarProgram = new StartaCarProgram();
            startCarProgram.BilÄgare = nyPerson;
            startCarProgram.Start();

            ListaPersoner.Add(nyPerson);
        }
    }
}
