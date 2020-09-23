using System;

namespace KlasserÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sam", lastName = "Zer", info = "Hej", marriedText = "n", ageAnswer = "n", shyaboutageAnswer;
            int age = 30;
            long birthDate = 123;
            bool married = false, isshyaboutage = false;
            DateTime dateTime = DateTime.Today;
            
            Console.Write($"Name: {name}");
            Console.Write($"\nLastname:  {lastName}");
            Console.Write($"\nPersonal Info:  {info}");
            Console.Write($"\nDrivers license date: {dateTime}");

            Console.Write($"\nMarried? y/n: ");
            if (marriedText == "y")
            {
                married = true;
            }
            else if (marriedText == "n")
            {
                married = false;
            }

            Console.Write($"\nAre you shy about your age? y/n: ");
            shyaboutageAnswer = Console.ReadLine();
            if (shyaboutageAnswer == "y")
            {
                isshyaboutage = true;
            }
            else if (shyaboutageAnswer == "n")
            {
                isshyaboutage = false;
            }

            Person person = new Person(name, lastName, info, married, dateTime, age, birthDate, isshyaboutage);

            Console.Write("Do you want to know your age? y/n: ");
            ageAnswer = Console.ReadLine();
            if (ageAnswer == "y")
            {
                Console.WriteLine($"Age: {person.GetAge()}");
            }

            Console.Write("Do you have a dog? y/n: ");
            string dogAnswer = Console.ReadLine();
            if (dogAnswer == "y")
            {
                var myDog = new KlasserÖvning2.Program();
                myDog.StartProgram();
                Console.WriteLine($"{myDog.DogOwnerName} has a dog named {myDog.DogName}");
                myDog.StartDogProgram();
                Console.WriteLine($"\n{myDog.DogName} says WOOFF");
                person.ByeBye();
            }
            else
                person.GetInfo();
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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalInfo { get; set; }
        public bool Married { get; set; }
        public DateTime? DriversLicensDate { get; set; }
        public bool IsShyAboutAge { get; set; }
        KlasserÖvning2.Dog Dog { get; set; }

        private int _age;
        private long _birthdate;

        public Person(string firstname, string lastname, string info, bool married, DateTime? licensdate, int age, long birthdate, bool isshyaboutage)
        {
            FirstName = firstname;
            LastName = lastname;
            PersonalInfo = info;
            Married = married;
            DriversLicensDate = licensdate;
            IsShyAboutAge = isshyaboutage;

            _age = age;
            _birthdate = birthdate;
        }

        public void ByeBye()
        {
            Console.WriteLine($"\nGoodbye!! best regards, {FirstName}");
        }

        public void GetInfo()
        {
            Console.WriteLine($"\nName: {FirstName}" +
                $"\nLastname: {LastName}" +
                $"\nAge: {_age}" +
                $"\nLastname: {_birthdate}" +
                $"\nInfo: {PersonalInfo}" +
                $"\nMarried: {Married}" +
                $"\nDriver license date: {DriversLicensDate}");
        }

        public int GetAge()
        {
            if (IsShyAboutAge)
            {
                return -1;
            }
            return _age;
        }

    }
}
