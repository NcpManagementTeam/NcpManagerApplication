using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NcpManagerApplication
{
    public partial class Login : Form
    {
        NcpManagerDbDataContext db = new NcpManagerDbDataContext();
        public Login()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var check = (from x in db.Passwords
                        where x.PasswordAttuale == txtPassword.Text
                        select x).ToList();

            if (check.Count>0)
            {
                Main mainForm = new Main();
                this.Hide();
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Password Errata");
                txtPassword.Text = "";
            }
        }

        
    }
}
