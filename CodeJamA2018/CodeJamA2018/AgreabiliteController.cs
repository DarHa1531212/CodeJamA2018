using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    /*static public class AgreabiliteController
    {
        static private List<Agreabilite> listeAgreabilite = new List<Agreabilite>();
        static private List<Utilisateur> userList = new List<Utilisateur>();
        static private uint maxGoldParDon = 5;
        static private uint maxGoldDonParJour = 50;

        static public uint GetMaxGoldParDon() { return maxGoldParDon; }

        static public uint GetMaxGoldDonParJour() { return maxGoldDonParJour; }

        static public void PushAgreabilite(Agreabilite agreabilite) {
            if (!listeAgreabilite.Contains(agreabilite))
            {
                listeAgreabilite.Add(agreabilite);
                listeAgreabilite.TrimExcess();
            }
        }

        static public void PopAgreabilite(Agreabilite agreabilite) {
            while (listeAgreabilite.Contains(agreabilite)) {
                listeAgreabilite.Remove(agreabilite);
            }
        }

        static public List<Utilisateur> GetUserList() {
            return userList;
        }

        static private void UpdateListeUtilisateurs() {
            userList = Database.GetUserList(); //va chercher la liste d'utilisateurs dans la base de données
        }

        static public void ReceiveReward(DemandeDeDon demande) {
            Database.GetUserList().Find(demande.GetReceveur()).GainGold(demande.GetAgreabilite().GetGold());
            Database.GetUserList().Find(demande.GetDonneur()).GetListeDons().Add(demande);
        }

    }*/
}