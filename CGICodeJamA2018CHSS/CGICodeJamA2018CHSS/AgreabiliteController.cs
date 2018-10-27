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

        static public void SetMaxGoldParDon(uint maxGold) { maxGoldParDon = maxGold; }

        static public uint GetMaxGoldParDon() { return maxGoldParDon; }

        static public void SetMaxGoldDonParJour(uint maxGold) { maxGoldDonParJour = maxGold; }

        static public uint GetMaxGoldDonParJour() { return maxGoldDonParJour; }

        static public void PushAgreabilite(Agreabilite agreabilite) {
            if (!listeActions.Contains(agreabilite))
            {
                listeActions.Add(agreabilite);
                listeActions.TrimExcess();
            }
        }

        static public void PopAgreabilite(Agreabilite agreabilite) {
            while (listeActions.Contains(agreabilite)) {
                listeActions.Remove(agreabilite);
            }
        }

        static public List<Utilisateur> GetListeUtilisateurs() {
            return userList;
        }

        static private void UpdateListeUtilisateurs() {
            userList = GetUserList(); //va chercher la liste d'utilisateurs dans la base de données
        }

        static public void ReceiveReward(DemandeDeDon demande) {
            demande.GetReceveur(); //...Implémenter le gain de gold
        }

    }
}