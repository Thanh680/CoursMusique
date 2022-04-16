using System;
using System.Collections.Generic;
using System.Text;

namespace Musique
{
    abstract class Cours
    {
        public static int id;
        public static int ageMini;
        private List<Jour> lesJours;

        public Cours(int unId,int ageMin)
        {
            lesJours = new List<Jour>();
        }

        public void ajouteJourCours(Jour j)
        {
            lesJours.Add(j);
        }

        public List<Jour> getListJours()
        {
            return lesJours;
        }

        public abstract override string ToString();
    }
}
