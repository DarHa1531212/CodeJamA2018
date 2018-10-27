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

        static public void pushAgreabilite(Agreabilite agreabilite) {
            listeActions.Add(agreabilite);
            listeActions.TrimExcess();
        }

        static public void popAgreabilite(Agreabilite agreabilite) {
            if (listeActions.Contains(agreabilite)) {
                listeActions.Remove(agreabilite);
            }
        }

        static public List<Utilisateur> getListeUtilisateurs() {
            return userList;
        }

        static private void updateListeUtilisateurs() {
            //userList = //entrer nom du get ListeUtilisateurs
        }

        static public void giveReward(Utilisateur giver, Utilisateur receiver, int amount) {
            if (giver != receiver && amount > 0 && maxGoldParDon >= amount) {
                //receiver.getGold(amount);
            }
        }

        static public setMaxGoldParDon(uint maxGold) {
            maxGoldParDon = maxGold;
        }
    }
}