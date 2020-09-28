using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    static class DummyData
    {
        private static Person _nyPerson;
        private static Bil _nyBil;

        public static StartHumanProgram StartHumanProgram { get; set; }

        public static StartHumanProgram LoadDummiesToList()
        {
            string[] NameArray = new string[] { "Shaq", "Irving", "Iverson"};
            int[] AgeArray = new int[] { 25, 30, 35};
            string[] BilModelArray = new string[] { "BMW", "Audi", "Volvo" };
            string[] RegArray = new string[] { "123", "456", "789" };
            string[] MSArray = new string[] { "5600", "7500", "3600" };
            string[] DragKrokArray = new string[] { "y", "n", "y" };

            _nyPerson = new Person();

            for (int i = 0; i < NameArray.Length; i++)
            {
                _nyPerson.Namn = NameArray[i];
                _nyPerson.Ålder = AgeArray[i];
                _nyBil = new Bil(BilModelArray[i], RegArray[i], MSArray[i], DragKrokArray[i]);
                _nyPerson.Fordon.Add(_nyBil);
                StartHumanProgram.ListaPersoner.Add(_nyPerson);
            }
            return StartHumanProgram;
        }
    }
}
