using System;
using System.Collections.Generic;
using System.Text;

namespace Musique
{
    class CoursCollectif : Cours
    {
        private string libelle;
        private int ageMaxi;
        private int nbPlaceMaxi;

        public CoursCollectif(int id, int ageMini, string lib, int ageMax, int nbMax) : base(id, ageMini)
        {
            this.libelle = lib;
            this.ageMaxi = ageMax;
            this.nbPlaceMaxi = nbMax;
        }

        public int GetAgeMaxi()
        {
            return ageMaxi;
        }

        public int GetNbPlaceMaxi()
        {
            return nbPlaceMaxi;
        }

        public string GetLibelle()
        {
            return libelle;
        }
        public override string ToString()
        {
            string msg = libelle + "\n";
            msg += "\t" + "music.CoursCollectif";
            msg += "\t" + "age minimum : " + ageMini;
            return msg;
        }
    }
}
