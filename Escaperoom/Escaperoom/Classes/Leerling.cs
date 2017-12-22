using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaperoom.Classes
{
    public class Leerling
    {
        private int _leerlingID;

        public int LeerLing
        {
            get { return _leerlingID; }
            set { _leerlingID = value; }
        }

        private string _naam;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }
        
        public Leerling(string naam, int id)
        {
            _naam = naam;
            _leerlingID = id;
        }
        public Leerling()
        {

        }
    }
}
