using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public abstract class Fordon : IVadFordonKanGöra
    {
        public string Modellnamn { get; set; }
        public string Registreringsnummer { get; set; }
        public string Mätare { get; set; }

        public abstract string GetSpecialTyp();

        public abstract string GetFordonsTyp();

        public abstract bool SetFordonIVerkstadStatus(bool status);

        public abstract string GetFordonIVerkstadStatus();

        //public abstract void SkrivIn();
    }

    /// <summary>
    /// Test -- Om man vill utöka programmet så att den håller Flygfordon eller Båtfordon så kan de nya klasserna ärva från denna interface.
    /// </summary>
    public interface IVadFordonKanGöra
    {
        string GetSpecialTyp();
        string GetFordonsTyp();
        bool SetFordonIVerkstadStatus(bool status);
        string GetFordonIVerkstadStatus();
    }
}
