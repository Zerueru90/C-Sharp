using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public interface IVerkstad
    {
        void LäggtillFordon(Fordon fordon);
        void TabortFordon(Fordon fordon, string regnr);
    }
}
