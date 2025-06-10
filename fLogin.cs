using diploma_216273.Modules;
using System;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Windows.Forms;

namespace diploma_216273
{
    public partial class fLogin : Form
    {
        public bool adminFlag = false;


        public fLogin()
        {
            InitializeComponent();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            string password = tPassword.Text;

            if (PasswordManager.CheckPassword(password))
            {
                MessageBox.Show("Login successful");
                adminFlag = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
