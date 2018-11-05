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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ControllerAccess reader = new ControllerAccess();
            tblUser user = new tblUser();
            user = reader.getUsers(txtUserNbr.Text);
            if (user == null)
            {
                MessageBox.Show("Unknown User");
            }
            else if (user.motPasse == txtPassword.Text)
            {
                loginInfo newLogin = new loginInfo();
                newLogin.setLogin(user);


                UserPage loggedPage = new UserPage();
                loggedPage.Show();
                    this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }

        }
    }
}
