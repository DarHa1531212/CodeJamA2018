using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    public class Agreabilite
    {
        private string name;
        private int xpValue;
        private int goldValue;

        Agreabilite(string nom, int xp, int gold) {
            setName(nom);
            setXp(xp);
            setGold(gold);
        }

        public string getName() {
            return name;
        }

        private void setName(string nom) {
            name = nom;
        }

        public int getXp()
        {
            return xpValue;
        }

        private void setXp(int xp)
        {
            xpValue = xp;
        }

        public int getGold()
        {
            return goldValue;
        }

        private void setGold(int gold)
        {
            goldValue = gold;
        }
    }
}