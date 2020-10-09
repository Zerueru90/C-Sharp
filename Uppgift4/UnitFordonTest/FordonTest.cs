using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArvOchAbstraktion;
using Klasser;

namespace UnitFordonTest
{
    [TestClass]
    public class FordonTest
    {
        [TestMethod]
        public void Fordon_SparaILista()
        {
            Person person = new Person();
            Bil bil = new Bil("BMW", "123abc", 5600, "y");


            person.Fordon.Add(bil);



        }
    }
}
