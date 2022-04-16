using System;

namespace Musique
{
    class Program
    {
        static void Main(string[] args)
        {
            Instrument I1 = new Instrument(1, "Piano");
            Instrument I2 = new Instrument(2, "Clarinette");
            Instrument I3 = new Instrument(3, "Tuba");
            Instrument I4 = new Instrument(4, "Violon");
            Instrument I5 = new Instrument(5, "Batterie");

            // Cours individuel de Piano
            Cours C1 = new CoursIndividuel(1, 5, I1);
            Cours C2 = new CoursIndividuel(2, 10, I1);
            // Cours individuel de Clarinette
            Cours C3 = new CoursIndividuel(3, 5, I2);
            // Cours individuel de Tuba
            Cours C4 = new CoursIndividuel(4, 6, I3);
            // Cours individuel de Violon
            Cours C5 = new CoursIndividuel(5, 10, I4);
            Cours C6 = new CoursIndividuel(6, 15, I4);
            // Cours individuel de Batterie
            Cours C7 = new CoursIndividuel(7, 8, I5);
            Cours C8 = new CoursIndividuel(8, 12, I5);

            Cours C9 = new CoursCollectif(9, 5, "Initiation musique", 7, 10);
            Cours C10 = new CoursCollectif(10, 5, "Solfège niveau 1", 10, 8);
            Cours C11 = new CoursCollectif(11, 8, "Solfège niveau 2", 15, 12);
            Cours C12 = new CoursCollectif(12, 5, "orchestre kids", 12, 30);
            Cours C13 = new CoursCollectif(13, 13, "Orchestre adulte", 77, 50);

            // Les jours de cours
            Jour J1 = new Jour(1, "Lundi");
            Jour J2 = new Jour(2, "Mardi");
            Jour J3 = new Jour(3, "Mercredi");
            Jour J4 = new Jour(4, "Jeudi");
            Jour J5 = new Jour(5, "Vendredi");
            Jour J6 = new Jour(6, "Samedi");
            Jour J7 = new Jour(7, "Dimanche");

            // Ajouter les cours aux jours
            C1.ajouteJourCours(J1);
            C1.ajouteJourCours(J2);
            C1.ajouteJourCours(J3);

            C2.ajouteJourCours(J1);
            C2.ajouteJourCours(J4);
            C2.ajouteJourCours(J2);
            C2.ajouteJourCours(J5);

            C3.ajouteJourCours(J4);
            C3.ajouteJourCours(J1);

            C4.ajouteJourCours(J6);
            C4.ajouteJourCours(J4);
            C4.ajouteJourCours(J3);
            C4.ajouteJourCours(J5);
            C4.ajouteJourCours(J7);

            C5.ajouteJourCours(J1);
            C5.ajouteJourCours(J6);

            C6.ajouteJourCours(J1);
            C6.ajouteJourCours(J2);
            C6.ajouteJourCours(J3);
            C6.ajouteJourCours(J5);
            C6.ajouteJourCours(J6);

            C7.ajouteJourCours(J1);
            C7.ajouteJourCours(J4);
            C7.ajouteJourCours(J5);
            C7.ajouteJourCours(J2);
            C7.ajouteJourCours(J6);

            C8.ajouteJourCours(J2);
            C8.ajouteJourCours(J3);
            C8.ajouteJourCours(J4);
            C8.ajouteJourCours(J5);
            C8.ajouteJourCours(J6);

            C9.ajouteJourCours(J1);

            C10.ajouteJourCours(J2);

            C11.ajouteJourCours(J3);

            C12.ajouteJourCours(J6);

            C13.ajouteJourCours(J7);

            // Le planning
            Planning P = new Planning();
            P.addJour(J1);
            P.addJour(J2);
            P.addJour(J3);
            P.addJour(J4);
            P.addJour(J5);
            P.addJour(J6);
            P.addJour(J7);

            P.addCours(C1);
            P.addCours(C2);
            P.addCours(C3);
            P.addCours(C4);
            P.addCours(C5);
            P.addCours(C6);
            P.addCours(C7);
            P.addCours(C8);
            P.addCours(C9);
            P.addCours(C10);
            P.addCours(C11);
            P.addCours(C12);
            P.addCours(C13);

            Console.WriteLine(P.ToString());
            Console.ReadKey();

        }
    }
}
