using CodeJamA2018.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJamA2018
{
    class ControllerAccess
    {

        public tblUser getUsers(string username)
        {
            Model1 model1 = new Model1();


            var query = from user in model1.tblUser
                        select user;

            foreach (var genreSelectionne in query)
            {
                if (username == genreSelectionne.noEmploye)
                {
                    return genreSelectionne;
                }
            }

            return null;

        }


        public List<CausesGainsXp> getUsersXpGains(int user)
        {
            using (Model1 model1 = new Model1())
            {
                List<CausesGainsXp> listValeuresDeRetour = new List<CausesGainsXp>();

                var query = (from xpGains in model1.tblXPGagne
                             join causesGainXp in model1.tblGainXP
                             on xpGains.idCauseGainXP equals causesGainXp.idCauseGain
                             where xpGains.idUser == user
                             select new
                             {
                                 qteXpGagne = xpGains.qteXPGagne,
                                 causeGain = causesGainXp.nomCauseGain
                             }).ToList();
                foreach (var trouve in query)
                {
                    CausesGainsXp elementActuel = new CausesGainsXp();
                    elementActuel.qteXpGagne = trouve.qteXpGagne;
                    elementActuel.causeGainXp = trouve.causeGain;
                    listValeuresDeRetour.Add(elementActuel);
                }
                return listValeuresDeRetour;

            }
        }

        public List<tblNiveau> GetLevels()
        {
            using (Model1 model1 = new Model1())
            {
                List<tblNiveau> listValeuresDeRetour = new List<tblNiveau>();

                var query = from niveaux in model1.tblNiveau
                            select niveaux;
                foreach (var trouve in query)
                {
                  //  tblNiveau elementActuel = new tblNiveau();
                    listValeuresDeRetour.Add(trouve);
                }
                return listValeuresDeRetour;

            }
        }
    }
}
