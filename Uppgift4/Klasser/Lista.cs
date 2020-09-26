using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Lista<T>
    {
        private List<T> _fordon;

        public List<T> Fordon
        {
            get
            {
                if (_fordon == null)
                {
                    return _fordon = new List<T>();
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
