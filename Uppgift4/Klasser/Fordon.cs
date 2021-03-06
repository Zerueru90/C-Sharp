﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public abstract class Fordon : IVadFordonKanGöra
    {
        public string Modellnamn { get; set; }
        public string Registreringsnummer { get; set; }
        public int Mätare { get; set; }

        public abstract string GetSpecialTyp();

        public abstract string GetFordonsTyp();

        public abstract bool SetFordonIVerkstadStatus(bool status);

        public abstract string GetFordonIVerkstadStatus();
    }
}
