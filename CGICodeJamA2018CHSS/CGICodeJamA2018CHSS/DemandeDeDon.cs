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
        private uint montant;
        private DateTime date;

        DemandeDeDon(Utilisateur giver, Utilisateur receiver, uint amount) {
            donneur = giver;
            receveur = receiver;
            montant = amount;
            date = DateTime.Now.Date;
        }

        public Utilisateur GetDonneur() { return donneur; }

        //public void SetDonneur() { } ?

        public Utilisateur GetReceveur() { return receveur; }

        public void SetReceveur(Utilisateur receiver) { receveur = receiver; }

        public uint GetMontant() { return montant; }

        public void SetMontant(uint amount) { montant = amount; }

        public DateTime GetDate() { return date; }
    }
}