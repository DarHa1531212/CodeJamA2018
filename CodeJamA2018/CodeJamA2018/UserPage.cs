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
            loginInfo user = new loginInfo();
            label1.Text = user.LogedInUser.prenomNom;
            lblXp.Text = "vous avez " + user.LogedInUser.xpTotal +" XP";

        }
    }
}
