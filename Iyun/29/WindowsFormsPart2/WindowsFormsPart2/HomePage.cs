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
    public partial class HomePage : Form
    {
        public HomePage(User user)
        {
            InitializeComponent();

            nameEdit.Text = user.Name;
            surnameEdit.Text = user.Surname;
            usernameEdit.Text = user.Username;
            passwordEdit.Text = user.Password;
            aboutUserEdit.Text = user.AboutUser;
            saveUserInfoBtn.Tag = user.Id;
        }

        private void saveUserInfoBtn_Click(object sender, EventArgs e)
        {
            int id = (int)saveUserInfoBtn.Tag;
            int index = VirtualDatabase.Users.FindIndex(i => i.Id == id);
            bool passwordIsChanged = false;

            if (VirtualDatabase.Users[index].Password != passwordEdit.Text)
            {
                passwordIsChanged = true;
            }

            VirtualDatabase.Users[index].Name = nameEdit.Text;
            VirtualDatabase.Users[index].Surname = surnameEdit.Text;
            VirtualDatabase.Users[index].Username = usernameEdit.Text;
            VirtualDatabase.Users[index].Password = passwordEdit.Text;
            VirtualDatabase.Users[index].AboutUser = aboutUserEdit.Text;

            MessageBox.Show("Melumatlar deyisdirildi!");

            if (passwordIsChanged)
            {
                this.Close();
            }
        }
    }
}
