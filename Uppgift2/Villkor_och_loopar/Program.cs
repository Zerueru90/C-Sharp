using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading;

namespace Villkor_och_loopar
{
    /// <summary>
    
       
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int startnummer, starttimme, startminut, startsekund,
                             måltimme, målminut, målsekund;
            int bästastartnummer = 0, deltagare = 0, nästBästaStartNummer = 0,  sluttid, 
                nästaBästaTid = int.MaxValue, bästaTid = int.MaxValue;

            bool loop = true;
            bool gameloop = true;
            while (gameloop)
            {

                while (loop)
                {
                    Console.Write("\nAnge startnummer: ");
                    bool korrektInput = int.TryParse(Console.ReadLine(), out startnummer);

                    if (startnummer < 1 && deltagare == 0)
                    {

                        Console.WriteLine("Inga tävlande");
                        loop = false;
                        gameloop = false;
                        Console.ReadLine();
                        break;
                    }
                    else if (startnummer < 1)
                    {
                        loop = false;
                        break;
                    }

                    starttimme = ReturnUserInput("\nAnge startimme: ", 0, 23);
                    startminut = ReturnUserInput("Ange startminut: ", 0, 59);
                    startsekund = ReturnUserInput("Ange startsekund: ", 0, 59);
                    måltimme = ReturnUserInput("\nAnge måltimme: ", 0, 23);
                    målminut = ReturnUserInput("Ange målminut: ", 0, 59);
                    målsekund = ReturnUserInput("Ange målsekund: ", 0, 59);

                    int totalSekunderStart = ConvertToSeconds(starttimme, startminut, startsekund);

                    int totalSekunderMål = ConvertToSeconds(måltimme, målminut, målsekund);

                    if (starttimme == 0 && måltimme == 0 && startminut == 0 && målminut == 0)
                    {

                        sluttid = SecondsFix(startsekund, målsekund);

                    }
                    else if (totalSekunderStart > totalSekunderMål)
                    {
                        sluttid = MidnightFix(starttimme, startminut, startsekund, måltimme, målminut, målsekund);
                    }
                    else
                    {
                        sluttid = totalSekunderMål - totalSekunderStart;
                    }

                    if (sluttid < bästaTid)
                    {
                        bästaTid = sluttid;
                        bästastartnummer = startnummer;
                    }
                    else if (sluttid < nästaBästaTid)
                    {
                        nästaBästaTid = sluttid;
                        nästBästaStartNummer = startnummer;
                    }
                    deltagare++;

                }
                if (deltagare != 0)
                {
                    //First place
                    string textFirstPlaceValue = ConvertBackFromSeconds(bästaTid);

                    string[] words = textFirstPlaceValue.Split('/');
                    int hour = 0, min = 0, sec = 0;

                    for (int i = 0; i < words.Length;)
                    {
                        hour = Convert.ToInt32(words[0]);
                        min = Convert.ToInt32(words[1]);
                        sec = Convert.ToInt32(words[2]);
                        break;
                    }

                    Console.WriteLine($"\nFörstaplats: startnummer {bästastartnummer}");
                    Console.WriteLine($"Förstaplats måltid: {hour} timme, {min} min, {sec} sek");
                    Console.WriteLine($"Deltagare: {deltagare}");

                    //Second place
                    if (deltagare > 1)
                    {
                        string textSecondPlaceValue = ConvertBackFromSeconds(nästaBästaTid);

                        string[] words2 = textSecondPlaceValue.Split('/');
                        int hour2 = 0, min2 = 0, sec2 = 0;

                        for (int i = 0; i < words2.Length;)
                        {
                            hour2 = Convert.ToInt32(words2[0]);
                            min2 = Convert.ToInt32(words2[1]);
                            sec2 = Convert.ToInt32(words2[2]);
                            break;
                        }

                        Console.WriteLine($"\nAndraplats: startnummer {nästBästaStartNummer}");
                        Console.WriteLine($"Andraplats måltid: {hour2} timme, {min2} min, {sec2} sek");
                        Console.WriteLine($"Deltagare: {deltagare}");
                    }

                    Console.WriteLine("Starta om? y/n");
                    string answer = Console.ReadLine();

                    if (answer == "n")
                    {
                        gameloop = false;
                    }
                    else if (answer == "y")
                    {
                        loop = true;
                        deltagare = 0;
                    }
                }
            }
        }

        public static int SecondsFix(int nightSec, int noonSec)
        {
            int sum = nightSec - noonSec;

            int h = 23, m = 59, s = 60;

            int summy = s - sum;

            int summy2 = ConvertToSeconds(h, m, summy);

            return summy2;
        }

        public static int MidnightFix(int nightHour, int nightMin, int nightSec, int noonHour, int noonMin, int noonSec)
        {
            int midnight = 24;
            int passedmidnight = 0;

            int minN = 60;

            if (nightHour == 23 || nightHour == 0)
            {
                midnight = 23;
            }

            int hoursLeftToMidnight = midnight - nightHour;

            if (nightMin == 0)
            {
                minN = 0;
            }
            int midnightMin = minN - nightMin;
            int midnightSec = nightSec;


            int hoursPastMidnight = noonHour - passedmidnight;
            int passedPastMidnightMin = noonMin;
            int passedPastMidnightSec = noonSec;


            int totalHours = hoursLeftToMidnight + hoursPastMidnight;
            int totalMin = midnightMin + passedPastMidnightMin;
            int totalSec = midnightSec + passedPastMidnightSec;

            int totalConvertedSec = ConvertToSeconds(totalHours, totalMin, totalSec);

            return totalConvertedSec;
        }

        public static int ConvertToSeconds(int hour, int min, int sec)
        {
            int timmeISekund = hour * 3600;

            int minutISekund = min * 60;

            int totalSekunderStart = timmeISekund + minutISekund + sec;

            return totalSekunderStart;
        }

        public static string ConvertBackFromSeconds(int winnerHighestValue)
        {
            double hour = winnerHighestValue / 3600;

            int finishHour = (int)hour;

            double minDouble = finishHour * 3600;

            double minDouble1 = winnerHighestValue - minDouble;

            double minDouble2 = minDouble1 / 60;

            int finishMin = (int)minDouble2;

            double secDouble = finishMin * 60;

            double sec = minDouble1 - secDouble;

            int finishSec = (int)sec;

            string test = Convert.ToString($"{finishHour} / {finishMin} / {finishSec}");

            return test;
        }

        public static bool CheckCorrectInputHour(int number)
        {
            return number > 23 || number < 0;
        }

        public static bool CheckCorrectInputMinSec(int number)
        {
            return number > 59 || number < 0;
        }

        public static int ReturnUserInput(string msg, int minValue, int maxValue)
        {
            bool convertOK = false;
            int timeUnit;
            string input;

            do
            {
                Console.Write($"{msg} ");
                input = Console.ReadLine();
                convertOK = int.TryParse(input, out timeUnit);
                
                if (convertOK)
                    convertOK = timeUnit <= maxValue && timeUnit >= minValue;
            } while (!convertOK);
            return timeUnit;
        }

    }
}
