using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
   /*public class BatchDons
    {
        private List<DemandeDeDon> batchDeDons = new List<DemandeDeDon>();
        private uint valeurTotale;
        private Utilisateur donneur;

        BatchDons(Utilisateur user) { donneur = user; }

        ~BatchDons() { }

        public void PushDemandeDeDon(DemandeDeDon demandeDeDon) {
            if (AgreabiliteController.GetMaxGoldDonParJour() > valeurTotale + demandeDeDon.GetAgreabilite().GetGold()) {
                batchDeDons.Add(demandeDeDon);
                valeurTotale += demandeDeDon.GetAgreabilite().GetGold();
            }
        }
        private bool CanReceiveReward(DemandeDeDon demande)
        {
            uint valeurDons = 0;
            List<DemandeDeDon> userData = new List<DemandeDeDon>();
            foreach (DemandeDeDon demandeDon in donneur.GetListeDons()) {
                if (demandeDon.GetDate() == DateTime.Now.Date && demandeDon.GetReceveur() == demande.GetReceveur()) {
                    userData.Add(demandeDon);
                    valeurDons += demandeDon.GetAgreabilite().GetGold();
                }
            }
            if (donneur != demande.GetDonneur() || demande.GetDonneur() == demande.GetReceveur() ||  valeurDons > AgreabiliteController.GetMaxGoldDonParJour())
            {
                return false;
            }
            return true;
        }

        public bool DemandesValides() {
            foreach (DemandeDeDon demande in batchDeDons) {
                if (!CanReceiveReward(demande)) {
                    return false;
                }
            }
            foreach (DemandeDeDon demande in batchDeDons) {
                AgreabiliteController.ReceiveReward(demande);
            }

            return true;
        }
    }*/
}