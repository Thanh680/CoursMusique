using System;
using System.Collections.Generic;
using System.Text;

namespace Musique
{
    class Instrument
    {
        private int id;
        private string intitule;

        public Instrument(int unId, string libelle)
        {
            this.id = unId;
            this.intitule = libelle;
        }

        public string getIntitule()
        {
            return intitule;
        }
    }
}
