using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
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
