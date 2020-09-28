using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    abstract class FlygFordon : IVadFordonKanGöra
    {
        public string Modellnamn { get; set; }
       
        public abstract string GetSpecialTyp();

        public abstract string GetFordonsTyp();

        public abstract bool SetFordonIVerkstadStatus(bool status);

        public abstract string GetFordonIVerkstadStatus();
    }

    //Exempel
    class StridsFlygplan : FlygFordon
    {

        public override string GetSpecialTyp() { return ""; }
               
        public override string GetFordonsTyp() { return ""; }

        public override bool SetFordonIVerkstadStatus(bool status) { return false; }
               
        public override string GetFordonIVerkstadStatus() { return ""; }
    }
}
