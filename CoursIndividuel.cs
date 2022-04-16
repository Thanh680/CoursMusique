using System;
using System.Collections.Generic;
using System.Text;

namespace Musique
{
    class CoursIndividuel : Cours
    {
        private Instrument Linstruments;

        public CoursIndividuel(int id, int ageMini,Instrument instru):base(id, ageMini)
        {
            this.Linstruments = instru;
        }

        public Instrument GetLinstrument()
        {
            return Linstruments;
        }

        public string GetLibelle()
        {
            return Linstruments.getIntitule();
        }

        public override string ToString()
        {
            string msg = Linstruments.getIntitule() +"\n";
            msg += "\t" + "music.CoursIndividuel";
            msg += "\t" + "age minimum : " + ageMini;
            return msg;
        }
    }
}
