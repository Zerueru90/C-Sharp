using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    static class FelhanteringKlass
    {
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

        public static string ReturnText(string msg)
        {
            bool convertOK = true;
            string input;
            int nr;
            do
            {
                Console.Write($"{msg} ");
                input = Console.ReadLine();
                convertOK = int.TryParse(input, out nr);

            } while (convertOK);
            return input;
        }

        public static string ReturnOnlyYesOrNo(string msg)
        {
            ConsoleKeyInfo keyInfo;

            bool convertOK = true;
            do
            {
                Console.Write($"\n{msg} ");
                keyInfo = Console.ReadKey();
                
                if (keyInfo.Key == ConsoleKey.Y || keyInfo.Key == ConsoleKey.N)
                {
                    convertOK = false;
                }

            } while (convertOK);
            return keyInfo.Key.ToString();
        }

        public static bool CheckListEmpty(int count)
        {
            if (count != 0)
            {
                return true;
            }
            return false;
        }

        public static int SwitchLimit(string msg, int maxNr)
        {
            bool convertOK = false;
            string input;
            int nr;
            do
            {
                Console.Write($"{msg} ");
                input = Console.ReadLine();
                convertOK = int.TryParse(input, out nr);

                if (nr > maxNr || nr < 1)
                {
                    convertOK = false;
                }

            } while (!convertOK);
            return nr;
        }
    }
}