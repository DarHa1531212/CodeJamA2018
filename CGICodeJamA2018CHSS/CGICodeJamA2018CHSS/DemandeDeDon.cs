using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    public class DemandeDeDon
    {
        public Utilisateur donneur;
        public Utilisateur receveur;
        public uint montant;

        DemandeDeDon(Utilisateur giver, Utilisateur receiver, uint amount) {
            donneur = giver;
            receveur = receiver;
            montant = amount;
        }
    }
}