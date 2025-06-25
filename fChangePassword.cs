using diploma_216273.Managers;
using System;
using System.Windows.Forms;

namespace diploma_216273
{
    public partial class fChangePassword : Form
    {
        bool passwordsValid = true;
        public fChangePassword()
        {
            InitializeComponent();
            tOldPass.UseSystemPasswordChar = !cShowText.Checked;
            tNewPass.UseSystemPasswordChar = !cShowText.Checked;
            tConfirm.UseSystemPasswordChar = !cShowText.Checked;
        }

        void validateLength(string str)
        {
            if (str.Length < 4 || str.Length > 20)
            {
                passwordsValid = false;
            }
        }
        private void bEnter_Click(object sender, EventArgs e)
        {
            
            string oldPassword = tOldPass.Text;
            string newPassword = tNewPass.Text;
            string confirmPassword = tConfirm.Text;

            validateLength(oldPassword);
            validateLength(newPassword);
            validateLength(confirmPassword);

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

        private void cShowText_CheckedChanged(object sender, EventArgs e)
        {
            tOldPass.UseSystemPasswordChar = !cShowText.Checked;
            tNewPass.UseSystemPasswordChar = !cShowText.Checked;
            tConfirm.UseSystemPasswordChar = !cShowText.Checked;
        }
    }
}
