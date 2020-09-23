using System;
using System.Runtime.CompilerServices;

namespace KlasserÖvning2
{
    public class Program
    {
        static void Main(string[] args)
        {
            var start = new Program();
            start.StartProgram();
        }

        public string DogName = "Fluffy";
        public string DogOwnerName = "Sam";
        private Dog myDog;

        public void StartProgram()
        {
            string walkAnswer, barkAnswer;
            int dogAge = 3;
            decimal dogWeight = 10;
            bool likesToBark = true, likesToWalk = true;

            Console.Write($"Dog name: {DogName}");
            Console.Write($"\nDog age: {dogAge}");
            Console.Write($"\nDog owner name: {DogOwnerName}");
            Console.Write($"\nDog weight: {dogWeight}");

            Console.Write($"\nDog like to walk? y/n: ");
            walkAnswer = Console.ReadLine();
            if (walkAnswer == "y")
            {
                likesToWalk = true;
            }
            else if (walkAnswer == "n")
            {
                likesToWalk = false;
            }
            Console.Write($"Dog like to bark? y/n: ");
            barkAnswer = Console.ReadLine();
            if (barkAnswer == "y")
            {
                likesToBark = true;
            }
            else if (barkAnswer == "n")
            {
                likesToBark = false;
            }


            myDog = new Dog(dogWeight, likesToBark, likesToWalk);
            myDog.DogName = DogName;
            myDog.DogAge = dogAge;
            myDog.NameOfDogOwner = DogOwnerName;

        }

        public void StartDogProgram()
        {
            bool loop = true;
            do
            {
                Console.WriteLine($"\n{DogName} awaits your orders...");
                Console.WriteLine($"Go for a walk: [1]");
                Console.WriteLine($"Make {DogName} bark: [2]");
                Console.WriteLine($"Feed: [3]");
                Console.WriteLine($"Get {DogName} status: [4]");
                Console.WriteLine($"Quit: [5]");
                int answer = int.Parse(Console.ReadLine());
                switch (answer)
                {
                    case 1:
                        myDog.GoForAWalk();
                        break;
                    case 2:
                        myDog.Bark();
                        break;
                    case 3:
                        Console.Write("How many bones do you want to give: ");
                        int food = int.Parse(Console.ReadLine());
                        myDog.Eat(food);
                        break;
                    case 4:
                        myDog.GetMyStatus();
                        break;
                    case 5:
                        loop = false;
                        break;
                    default:
                        break;
                }
            } while (loop);
        }
    }

    public class Dog
    {

        public string DogName { get; set; }
        public int DogAge { get; set; }
        public string NameOfDogOwner { get; set; }

        private decimal _weight;
        private bool _likesToBark;
        private bool _likesToWalk;
        private int _amountOfWalks;

        public Dog(decimal weight, bool likebark, bool likewalk)
        {
            _weight = weight;
            _likesToBark = likebark;
            _likesToWalk = likewalk;
        }

        public Dog(string dogname, int dogage, string ownername)
        {
            DogName = dogname;
            DogAge = dogage;
            NameOfDogOwner = ownername;
        }



        public void GoForAWalk()
        {
            if (_likesToWalk)
            {
                _amountOfWalks++;
                Console.WriteLine($"You went for a walk with {DogName}");
                _weight -= 1;
            }
            else
            _weight -= 0.5M;
        }

        public void Bark()
        {
            if (_likesToBark)
            {
                Console.WriteLine("WOFF");
            }
        }
        public void Eat(int amountOfBones)
        {
            _weight += amountOfBones * 0.7M;
        }

        public void GetMyStatus()
        {
            Console.WriteLine($"--------------------");
            Console.WriteLine($"{DogName} status");
            Console.WriteLine($"Age: {DogAge}");
            Console.WriteLine($"Weight: {_weight}");
            Console.WriteLine($"Walks: {_amountOfWalks}");
            Console.WriteLine($"--------------------");
        }
    }
}
