using diploma_216273.Managers;
using System;
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
            bool passwordValidLength = true;
            string password = tPassword.Text;

            if (password.Length > 20 || password.Length < 4)
            {
                MessageBox.Show("Password can be between 5 and 20 characters");
                passwordValidLength = false;
            }

            if (passwordValidLength)
            {
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
            

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }

}
