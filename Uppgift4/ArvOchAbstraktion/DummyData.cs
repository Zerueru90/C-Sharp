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

        public static void LoadDummiesToList()
        {
            string[] NameArray = new string[] { "Sam", "Shaq", "Mike"};
            int[] AgeArray = new int[] { 25, 30, 35};
            string[] BilModelArray = new string[] { "BMW", "Audi", "Volvo" };
            string[] RegArray = new string[] { "123abc", "456abc", "789abc" };
            int[] MSArray = new int[] { 5600, 7500, 3600 };
            string[] DragKrokArray = new string[] { "y", "n", "y" };

            
            for (int i = 0; i < NameArray.Length; i++)
            {
                _nyPerson = new Person();

                _nyPerson.Namn = NameArray[i];
                _nyPerson.Ålder = AgeArray[i];
                _nyBil = new Bil(BilModelArray[i], RegArray[i], MSArray[i], DragKrokArray[i]);
                _nyPerson.Fordon.Add(_nyBil);
                KlassLista<Person>.GeneriskLista.Add(_nyPerson);
            }
        }
    }
}
