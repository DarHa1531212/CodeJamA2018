using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CGICodeJamA2018CHSS
{
    public class Agreabilite
    {
        private string name;
        private uint goldValue;

        Agreabilite(string nom, uint gold) {
            SetName(nom);
            SetGold(gold);
        }

        public string GetName() {
            return name;
        }

        private void SetName(string nom) {
            name = nom;
        }

        public uint GetGold()
        {
            return goldValue;
        }

        public void SetGold(uint gold)
        {
            goldValue = gold;
        }
    }
}