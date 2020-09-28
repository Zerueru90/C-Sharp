using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Person
    {
        public String Namn { get; set; }
        public Int32 Ålder { get; set; }

        private List<Fordon> _fordon;

        public List<Fordon> Fordon
        {
            get
            {
                if (_fordon == null)
                {
                    return _fordon = new List<Fordon>();
                }
                return _fordon;
            }
            set
            {
                _fordon = value;
            }
        }
    }
}
