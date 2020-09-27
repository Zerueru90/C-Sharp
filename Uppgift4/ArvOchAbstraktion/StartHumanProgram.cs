﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    class StartHumanProgram
    {
        private Person _nyPerson;

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
            startCarProgram.BilÄgare = _nyPerson;
            startCarProgram.Start();

            ListaPersoner.Add(_nyPerson);
        }
    }
}
