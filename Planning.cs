using System;
using System.Collections.Generic;
using System.Text;

namespace Musique
{
    class Planning
    {
        private List<Jour> lesJours;
        private List<Cours> lesCours;

        public Planning()
        {
            lesJours = new List<Jour>();
            lesCours = new List<Cours>();
        }

        public void addJour(Jour j)
        {
            lesJours.Add(j);
        }

        public void addCours(Cours c)
        {
            lesCours.Add(c);
        }

        public List<Jour> CoursJour(Jour unJour)
        {
            return lesJours;
        }

        public Dictionary<Jour,List<Cours>> CoursSemaine()
        {
            Dictionary<Jour, List<Cours>> dictio = new Dictionary<Jour, List<Cours>>();
            List<Cours> listCours = new List<Cours>();
            foreach (Jour j in lesJours)
            {
                foreach(Cours c in lesCours)
                {
                    foreach(Jour jour in c.getListJours())
                    {
                        if (jour == j)
                        {
                            listCours.Add(c);
                        }
                    }
                }
                dictio.Add(j, listCours);
                listCours.Clear();
            }
            return dictio;
        }

        public override string ToString()
        {
            string msg = "";
            foreach(KeyValuePair<Jour,List<Cours>> d in CoursSemaine())
            {
                msg += d.Key.GetLibelle() + "\n";
                foreach (Cours c in d.Value)
                    msg += "\t" + c.ToString();
            }
            return msg;
        }
    }
}
