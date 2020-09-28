using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Klasser
{
    public static class KlassLista<T>
    {
        private static List<T> _generiskLista;

        public static List<T> GeneriskLista
        {
            get
            {
                if (_generiskLista == null)
                {
                    return _generiskLista = new List<T>();
                }
                return _generiskLista;
            }
            set
            {
                _generiskLista = value;
            }
        }
    }
}
