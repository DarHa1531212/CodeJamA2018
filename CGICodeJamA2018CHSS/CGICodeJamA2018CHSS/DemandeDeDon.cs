using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    public class DemandeDeDon
    {
        private Utilisateur donneur;
        private Utilisateur receveur;
        private Agreabilite agreabilite;
        private DateTime date;

        DemandeDeDon(Utilisateur giver, Utilisateur receiver, Agreabilite agreability) {
            donneur = giver;
            receveur = receiver;
            agreabilite = agreability;
            date = DateTime.Now.Date;
        }

        public Utilisateur GetDonneur() { return donneur; }

        //public void SetDonneur() { } ?

        public Utilisateur GetReceveur() { return receveur; }

        public void SetReceveur(Utilisateur receiver) { receveur = receiver; }

        public Agreabilite GetAgreabilite() { return agreabilite; }

        public DateTime GetDate() { return date; }
    }
}