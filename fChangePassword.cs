using diploma_216273.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diploma_216273
{
    public partial class fChangePassword : Form
    {
        public fChangePassword()
        {
            InitializeComponent();
        }

        private void bEnter_Click(object sender, EventArgs e)
        {
            bool passwordsValid = true;
            string oldPassword = tOldPass.Text;
            string newPassword = tNewPass.Text;
            string confirmPassword = tConfirm.Text;

            if (oldPassword.Length < 4 || oldPassword.Length > 20)
            {
                passwordsValid = false;
            }

            if (newPassword.Length < 4 || newPassword.Length > 20)
            {
                passwordsValid = false;
            }

            if (confirmPassword.Length < 4 || confirmPassword.Length > 20)
            {
                passwordsValid = false;
            }

            if (passwordsValid)
            {
                if (!PasswordManager.CheckPassword(tOldPass.Text))
                {
                    MessageBox.Show("Old password is incorrect.");
                    return;
                }

                if (tNewPass.Text != tConfirm.Text)
                {
                    MessageBox.Show("New passwords do not match.");
                    return;
                }

                PasswordManager.SaveNewPassword(tNewPass.Text);
                MessageBox.Show("Password changed.");
                this.Close();
            }

            else
            {
                MessageBox.Show("Password must be between 4 and 20 characters");
            }
            
        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
