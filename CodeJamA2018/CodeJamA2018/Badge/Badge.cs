using CodeJamA2018;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    public class Badge
    {
        string prenomnom;
        string id;

        int pushAccepte;
        int pushRefuse;
        int ratio;
        int anciennete;
        int niveau;

        DateTime dateTime = DateTime.UtcNow.Date;

        List<tblUser> listUser = new List<tblUser>();

        tblUser utilisateur = new tblUser();
        tblNiveau niveauUtilisateur = new tblNiveau();

        void main()
        {
            BadgeNiveau();
            BadgeAnciennete();
            BadgeNoel();
            BadgeBowling();
            BadgeStValentin();
            BadgeHalloween();
            BadgeBarbecue();
            BadgeAdministration();
            BadgeParticipationJeu();
            BadgeParticipationActivite();
            BadgeRatio();
            BadgeAgreabilite();

            return;
        }

        public void BadgeNiveau()
        {
            if (utilisateur.xpTotal >= niveauUtilisateur.xpMinNiveau)
            {
                niveau = niveauUtilisateur.idNiveau;
            }
            
            if (niveau >= 30)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 7;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (niveau >= 25)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 6;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (niveau >= 20)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 5;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (niveau >= 15)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 4;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (niveau >= 10)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 3;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (niveau >= 5)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 2;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (niveau >= 1)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 1;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            return;
        }

        public void BadgeAnciennete()
        {  
            //anciennete = (dateTime - utilisateur.dateEmbaudhe);

            if (anciennete >= 40)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 16;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (anciennete >= 35)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 15;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (anciennete >= 30)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 14;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (anciennete >= 25)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 13;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (anciennete >= 20)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 12;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (anciennete >= 15)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 11;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (anciennete >= 10)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 10;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            else if (anciennete >= 5)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 9;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }

            else if (anciennete >= 1)
            {
                tbluserBadge nouveauBadge = new tbluserBadge();
                nouveauBadge.idBadge = 8;
                nouveauBadge.idUser = utilisateur.idemploye;
                nouveauBadge.dateObtention = dateTime;
            }
            return;
        }

        public void BadgeNoel()
        {

            return;
        }
        public void BadgeBowling()
        {
            return;
        }
        public void BadgeStValentin()
        {
            return;
        }
        public void BadgeHalloween()
        {
            return;
        }
        public void BadgeBarbecue()
        {
            return;
        }
        public void BadgeAdministration()
        {
            return;
        }
        public void BadgeParticipationJeu()
        {
            return;
        }

        public void BadgeParticipationActivite()
        {
            return;
        }

        public void BadgeRatio()
        {
            return;
        }

        public void BadgeAgreabilite()
        {
            return;
        }
    }

    
}

