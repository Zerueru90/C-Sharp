using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string regnr, modellnamn, namn;
            int vikt, ålder, ms;
            bool elbil = false, loop = true;
            DateTime regdatum;

            Bil bil;
            Person person;
            List <Person> listPersoner = new List<Person>();

            while (loop)
            {

                Console.Write("Namn: ");
                namn = Console.ReadLine();

                ålder = ReturnNumber("Ålder: ");

                Console.WriteLine("------------------------------- \nBil information");
                Console.Write("\nModel: ");
                modellnamn = Console.ReadLine();

                Console.Write("Reg nr: ");
                regnr = Console.ReadLine();

                regdatum = DateTime.Today;
                Console.Write($"Reg datum: {regdatum}");

                vikt = ReturnNumber("\nVikt: ");
                ms = ReturnNumber("Mätarställning: ");

                Console.Write("Är detta en elbil, y/n: ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    elbil = true;
                }
                else if (answer == "n")
                {
                    elbil = false;
                }
                else
                {
                    //Om någon inte skriver in yes eller no.
                }

                bil = new Bil(modellnamn, vikt, regdatum, elbil, regnr, ms);

                person = new Person(namn, ålder, bil);

                listPersoner.Add(person);

                foreach (var item in listPersoner)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Namn: {item.Namn} " +
                                      $"\nÅlder: {item.Ålder} " +
                                      $"\nModel: {item.Bil.Modellnamn} " +
                                      $"\nRegistreringsnummer: {item.Bil.Regnr} " +
                                      $"\nReg Datum: {item.Bil.DateTime} " +
                                      $"\n {item.Bil.ToString()}");
                    Console.WriteLine("-------------------------------");
                }

                Console.Write("\nDo you want to quit? y/n: ");
                string quit = Console.ReadLine();

                if (quit == "y")
                {
                    loop = false;
                }
            }
        }

        public static int ReturnNumber(string msg)
        {
            bool convertOK = false;
            string input;
            int nr;
            do
            {
                Console.Write($"{msg} ");
                input = Console.ReadLine();
                convertOK = int.TryParse(input, out nr);

            } while (!convertOK);
            return nr;
        }
    }

    public class Bil
    {
        //Properties
        public Int32 Vikt { get; set; }
        public DateTime DateTime { get; set; }
        public Boolean Elbil { get; set; }

        //Fält
        private string _modellnamn;
        protected decimal _milmätare;
        private string _regnr;

        public Bil(string modellnamn, int vikt, DateTime dateTime, bool elbil, string regnr, int ms)
        {
            Vikt = vikt;
            DateTime = dateTime;
            Elbil = elbil;

            Modellnamn = modellnamn;
            Regnr = regnr;
            Milmätare = ms;
        }

        public decimal Milmätare
        {
            get { return this._milmätare; }
            set { this._milmätare = value; }
        }

        public string Modellnamn
        {
            get { return this._modellnamn; }
            set { this._modellnamn = value; }
        }

        public string Regnr
        {
            get { return this._regnr; }
            set { this._regnr = value; }
        }


        public override string ToString()
        {
            if (Elbil == true)
            {
                return $" Detta är en elbil! ";
            }
            else
                return $" Detta är INTE en elbil! ";
        }

        public string UppdateraMS(decimal ms)
        {
            _milmätare += ms;
            string stringMS = Convert.ToString(_milmätare);
            return stringMS;
        }
    }

    public class Person
    {
        public String Namn { get; set; }
        public Int32 Ålder { get; set; }
        public Bil Bil { get; set; }
        
        public Person(string namn, int ålder, Bil bil)
        {
            Namn = namn;
            Ålder = ålder;
            Bil = bil;
        }
    }
}