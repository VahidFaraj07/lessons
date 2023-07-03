using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPart2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginMethod(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            User foundUser = VirtualDatabase.Users.Find(m => m.Username == username && m.Password == password);

            if (foundUser != null)
            {
                HomePage homePage = new HomePage(foundUser);
                homePage.Show();
            }
            else
            {
                MessageBox.Show("İstifadəçi məlumatları yanlışdır!", "Xəta!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextboxEnterColor(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.Yellow;
        }

        private void TextboxLeaveColor(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void TextboxColor(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (textBox.BackColor == Color.White)
            {
                textBox.BackColor = Color.Yellow;
            }
            else if (textBox.BackColor == Color.Yellow)
            {
                textBox.BackColor = Color.White;
            }
        }

    }
}
