using System;

namespace KlasserÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, lastName, info, marriedText;
            int age;
            long birthdate;
            bool married = false;
            DateTime dateTime = DateTime.Today;

            Console.Write($"Name: {name = Console.ReadLine()}");
            Console.Write($"Lastname: {lastName = Console.ReadLine()}");
            age = ReturnNumber("Age: ");
            birthdate = ReturnNumber("Birthdate: ");
            Console.Write($"Personal Info: {info = Console.ReadLine()}");
            Console.Write($"Married? y/n: {marriedText = Console.ReadLine()}");
            if (marriedText == "y")
            {
                married = true;
            }
            else if (marriedText == "n")
            {
                married = false;
            }
            Console.Write($"Drivers license date: {dateTime}");

            Person person = new Person(name, lastName, info, married, dateTime);
            
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

    class Person
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string PersonalInfo { get; set; }
        bool Married { get; set; }
        DateTime? DriversLicensDate { get; set; }

        private int _age;
        private int _birthdate;

        public Person(string firstname, string lastname, string info, bool married, DateTime? licensdate, int age, int birthdate)
        {
            FirstName = firstname;
            LastName = lastname;
            PersonalInfo = info;
            Married = married;
            DriversLicensDate = licensdate;

            Age = age;
            Birthdate = birthdate;
        }

        public int Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        public int Birthdate
        {
            get { return this._birthdate; }
            set { this._birthdate = value; }
        }

    }
}
