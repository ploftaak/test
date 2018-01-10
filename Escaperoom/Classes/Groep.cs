using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escaperoom.Classes
{
    public class Groep
    {
        private int _groepID;

        public int GroepID
        {
            get { return _groepID; }
            set { _groepID = value; }
        }

        private string _naam;

        public string Naam
        {
            get { return _naam; }
            set { _naam = value; }
        }

        public Groep(string naam, int groepID)
        {
            this._naam = naam;
            this._groepID = groepID;
        }

        public Groep(string naam)
        {
            _naam = naam;
        }

        public Groep()
        {

        }
    }
}
