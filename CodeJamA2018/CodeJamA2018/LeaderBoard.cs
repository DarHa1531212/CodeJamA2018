using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{

    public class LeaderBoard
    {
        string[] tableauNom = new string[3];
        int ratio;

        void main()
        {
            CreeTableauNom();
            Board();
            return;
        }


        string[] CreeTableauNom()
        {
            for (tblUser.)
                tableauNom[0] = tblUser.prenomNom;
            tableauNom[1] = tblUser.prenomNom;
            tableauNom[2] = tblUser.prenomNom;

            return tableauNom;

        }

        void Board()
        {
            Console.WriteLine("#1 " + tableauNom[0] + " " + ratio);
            Console.WriteLine("#2 " + tableauNom[2] + " " + ratio);
            Console.WriteLine("#3 " + tableauNom[3] + " " + ratio);

            return;

        }
    }

}