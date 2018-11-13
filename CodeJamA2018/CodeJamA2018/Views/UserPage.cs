using CodeJamA2018.Model;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeJamA2018
{
    public partial class UserPage : Form
    {
        loginInfo user = new loginInfo();
        ControllerAccess accesData = new ControllerAccess();
        public UserPage()
        {
            InitializeComponent();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            SetXpGainsLabels();
            SerUserNameXpLbls();
            SetLblXp();
            SetlblAnciennete();
        }

        private void SetlblAnciennete()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);

            DateTime embauche = new DateTime();
            DateTime adj = new DateTime();

            adj = DateTime.Now;
            embauche = user.LogedInUser.dateEmbaudhe;

            TimeSpan span = adj - embauche;
            // Because we start at year 1 for the Gregorian
            // calendar, we must subtract a year here.
            int years = (zeroTime + span).Year - 1;

            // 1, where my other algorithm resulted in 0.
            lblAnciennete.Text = "Vous avez " + years + " ans d'ancienneté";
            Console.WriteLine("Yrs elapsed: " + years);
        }

        private void SetLblXp()
        {
            int i = 0;
            List<tblNiveau> lstNiveaux =  accesData.GetLevels();
            while (lstNiveaux[i].xpMinNiveau < user.LogedInUser.xpTotal)
            {
                i++;
            }
            lblLevel.Text = "Vous êtes niveau " + i;


        }

        private void SetXpGainsLabels()
        {
            List<CausesGainsXp> causesGainXPs = new List<CausesGainsXp>();
            int nbreGainsXP;
            
            causesGainXPs = accesData.getUsersXpGains(user.LogedInUser.idemploye);
            nbreGainsXP = causesGainXPs.Count();

            Label[] labels = new Label[nbreGainsXP];
            for (int i = 0; i < nbreGainsXP; i++)
            {
                labels[i] = new Label();
                labels[i].Text = causesGainXPs[i].qteXpGagne + "Xp Gagné avec cause: " + causesGainXPs[i].causeGainXp;
                labels[i].Width = TextRenderer.MeasureText(labels[i].Text, labels[i].Font).Width;
            }

            // This adds the controls to the form (you will need to specify thier co-ordinates etc. first)
            for (int i = 0; i < nbreGainsXP; i++)
            {
                panGainsXP.Controls.Add(labels[i]);
                labels[i].Location = new Point(6, 23 * i + 17);
            }
        }

        private void SerUserNameXpLbls()
        {
            lblNom.Text = user.LogedInUser.prenomNom;
            lblXp.Text = "vous avez " + user.LogedInUser.xpTotal + " XP";
        }

        private void UserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
