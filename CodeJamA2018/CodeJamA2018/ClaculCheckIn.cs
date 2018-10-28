using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    public class CalculCheckIn
    {

        public struct Utilisateur
        {
            public int idUser;
            public int ratio;
        }
        int ratio;

        List<Utilisateur> listeRatio = new List<Utilisateur>();

        List<tblCheckIn> listeCheckIn = new List<tblCheckIn>();

        Utilisateur userRatio;

        //création de la listeCheckIn
        tblCheckIn CreationListeCheckIn()
        {

            return listeCheckIn;
        }
        int CalculRatio()
        {
            int pushaccepte = 0;
            int pushrefuse = 0;


            while (tblCheckIn != 0)
            {
                for (idUser
                if (accepte = true)
                        pushaccepte++;
                if (accepte = false)
                    pushrefuse++;
            }
            tblCheckIn a = new tblCheckIn();

            ratio = pushaccepte / pushrefuse;

            userRatio = new Utilisateur();

            userRatio.idUser = a.idUser;
            userRatio.ratio = ratio;

            listeRatio
                foreach (var x in listeRatio)
            {
                x.
            }
            return ratio;
        }
    }
}