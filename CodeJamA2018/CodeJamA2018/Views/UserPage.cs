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
        public UserPage()
        {
            InitializeComponent();
        }

        private void UserPage_Load(object sender, EventArgs e)
        {
            label1.BringToFront();

            List<CausesGainsXp> causesGainXPs = new List<CausesGainsXp>();
            int nbreGainsXP;

            loginInfo user = new loginInfo();
            label1.Text = user.LogedInUser.prenomNom;
            lblXp.Text = "vous avez " + user.LogedInUser.xpTotal + " XP";

            ControllerAccess accesData = new ControllerAccess();
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
                groupBox2.Controls.Add(labels[i]);
                labels[i].Location = new Point(6, 23 * i + 17);
            }
        }

        private void UserPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
