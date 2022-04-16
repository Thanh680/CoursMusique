using System;
using System.Collections.Generic;
using System.Text;

namespace Musique
{
    class Jour
    {
        private int id;
        private string libelle;

        public Jour (int i, string lib)
        {
            this.id = i;
            this.libelle = lib;
        }

        public int GetId()
        {
            return this.id;
        }

        public string GetLibelle()
        {
            return this.libelle;
        }
    }
}
