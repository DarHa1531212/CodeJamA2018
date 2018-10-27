using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    static public class AgreabiliteController
    {
        static private List<Agreabilite> listeActions = new List<Agreabilite>();
        static private List<Utilisateur> userList = new List<Utilisateur>();
        static private uint maxGoldParDon = 0;
        static private uint maxGoldDonParJour = 0;

        static public void setMaxGoldParDon(uint maxGold) { maxGoldParDon = maxGold; }

        static public uint getMaxGoldParDon() { return maxGoldParDon; }

        static public void setMaxGoldDonParJour(uint maxGold) { maxGoldDonParJour = maxGold; }

        static public uint getMaxGoldDonParJour() { return maxGoldDonParJour; }

        static public void pushAgreabilite(Agreabilite agreabilite) {
            if (!listeActions.Contains(agreabilite))
            {
                listeActions.Add(agreabilite);
                listeActions.TrimExcess();
            }
        }

        static public void popAgreabilite(Agreabilite agreabilite) {
            while (listeActions.Contains(agreabilite)) {
                listeActions.Remove(agreabilite);
            }
        }

        static public List<Utilisateur> getListeUtilisateurs() {
            return userList;
        }

        static private void updateListeUtilisateurs() {
            //userList = getUserList();
        }

        static private bool canReceiveReward(DemandeDeDon demande) {
            if (true /*demande n'existe pas déjà et respecte les normes*/ ) {
                //receiver.getGold(amount);
            }
            return true; //À changer
        }

        //travailler avec classe giver, receiver, amount
    }
}