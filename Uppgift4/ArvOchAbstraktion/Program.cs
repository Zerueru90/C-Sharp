using System;
using System.Security.Cryptography.X509Certificates;

namespace ArvOchAbstraktion
{
    class Program 
    {
        /*
            När du fått det att fungera kan du prova att skapa en ny klass, VerkstadV2, 
            ärva av IVerkstad men skriva annan funktionalitet. 
            Se att användning av IVerkstad i Main inte påverkas. (Styrkan med ett interface).
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Verkstad vst = new Verkstad();
            vst.läggtillFordon();

        }

    }
    interface IVerkstad
    {
        void läggtillFordon();
        void tabortFordon();
    }

    class Verkstad : IVerkstad
    {
        public void läggtillFordon()
        {

        }
        public void tabortFordon()
        {

        }
    }

    class VerkstadV2 : IVerkstad
    {
        public void läggtillFordon()
        {

        }
        public void tabortFordon()
        {

        }
    }
}
