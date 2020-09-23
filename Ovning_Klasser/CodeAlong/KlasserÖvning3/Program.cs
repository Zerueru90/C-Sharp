using System;

namespace KlasserÖvning3
{
    class Program
    {
        static void Main(string[] args)
        {
            string lionName = "Lion", tigerName = "tiger";
            Console.Write($"Lion name: {lionName}");
            Console.Write($"Tiger name: {tigerName}");

            var newLion = new Lion();
            var copyLion = new Lion();

            var newTiger = new Tiger();
            var copyTiger = new Tiger();

            copyLion = newLion;
            copyTiger = newTiger;
        }
    }

    public class Lion
    {
        public string LionName { get; set; }
        public string LionCountry { get; set; }
        public int LionAge { get; set; }
    }

    public struct Tiger
    {
        public string TigerName { get; set; }
        public string TigerCountry { get; set; }
        public int TigerAge { get; set; }

    }
}
