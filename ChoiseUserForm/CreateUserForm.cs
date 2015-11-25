using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class CreateUserForm : Form
    {
        bool TrueLogin=false;
        bool TruePassword = false;
        bool ComparePassword = false;
        LogForm f;
        public CreateUserForm(LogForm f,List<User> AllUsers)
        {
            this.f = f;
            this.AllUsers = AllUsers;
            InitializeComponent();
        }
        List<User> AllUsers;
        private void CloseBut_Click(object sender, EventArgs e)
        {
            f.Show();
            Close();
        }

        private void DeleteErrorMessage(int i)
        {
            if (i == 0)
            {
                if (ErrorLab1.Text == "Such username already exists")
                {
                    ErrorLab1.Text = ErrorLab2.Text;
                    ErrorLab2.Text = ErrorLab3.Text;
                    ErrorLab3.Text = "";
                }
            }
            else if (i == 1)
            {
                if (ErrorLab1.Text == "So shortly password. It must be biger than 7 symbols")
                {
                    ErrorLab1.Text = ErrorLab2.Text;
                    ErrorLab2.Text = ErrorLab3.Text;
                    ErrorLab3.Text = "";
                }
                else if (ErrorLab2.Text == "So shortly password. It must be biger than 7 symbols")
                {
                    ErrorLab2.Text = ErrorLab3.Text;
                    ErrorLab3.Text = "";
                }
            }
            else if (i == 2)
            {
                if (ErrorLab1.Text == "Passwords dont compare each other")
                    ErrorLab1.Text = "";
                else if (ErrorLab2.Text == "Passwords dont compare each other")
                    ErrorLab2.Text = "";
                else if (ErrorLab3.Text == "Passwords dont compare each other")
                    ErrorLab3.Text = "";
            }
        }

        private void CreateErrorMessage(int i)
        {
            if (i == 0)
            {
                ErrorLab3.Text = ErrorLab2.Text;
                ErrorLab2.Text = ErrorLab1.Text;
                ErrorLab1.Text = "Such username already exists";
            }
            else if (i == 1)
            {
                if (ErrorLab1.Text.Length == 0)
                    ErrorLab1.Text = "So shortly password. It must be biger than 7 symbols";
                else if (ErrorLab1.Text == "Passwords dont compare each other")
                {
                    ErrorLab2.Text = ErrorLab1.Text;
                    ErrorLab1.Text = "So shortly password. It must be biger than 7 symbols";
                }
                else
                {
                    ErrorLab3.Text = ErrorLab2.Text;
                    ErrorLab2.Text = "So shortly password. It must be biger than 7 symbols";
                }
            }
            else if (i == 2)
            {
                if (ErrorLab1.Text.Length == 0)
                    ErrorLab1.Text = "Passwords dont compare each other";
                else if (ErrorLab2.Text.Length == 0)
                    ErrorLab2.Text = "Passwords dont compare each other";
                else
                    ErrorLab3.Text = "Passwords dont compare each other";
            }
        }

        private void LoginTB_TextChanged(object sender, EventArgs e)
        {
            bool tmp = true;
            string log = LoginTB.Text;
            foreach (var u in AllUsers)
            {
                if (u.Login() == log)
                {
                    tmp = false;
                    break;
                }
            }
            TrueLogin = tmp;
            if (tmp&&log.Length>0)
            {
                LoginLab.ForeColor = Color.LawnGreen;
                LoginLab.Text = "Ok";
            }
            else
            {
                LoginLab.ForeColor = Color.IndianRed;
                LoginLab.Text = "No";
            }
        }

        private void Password2TB_TextChanged(object sender, EventArgs e)
        {
            if (Password1TB.Text == Password2TB.Text)
            {
                ComparePassword = true;
                Password2Lab.ForeColor = Color.LawnGreen;
                Password2Lab.Text = "Ok";
            }
            else
            {
                Password2Lab.ForeColor = Color.IndianRed;
                Password2Lab.Text = "No";
                ComparePassword = false;
            }
        }

        private void Password1TB_TextChanged(object sender, EventArgs e)
        {
            if (Password1TB.Text.Length > 7)
            {
                TruePassword = true;
                Password1Lab.ForeColor = Color.LawnGreen;
                Password1Lab.Text = "Ok";
            }
            else
            {
                TruePassword = false;
                Password1Lab.ForeColor = Color.IndianRed;
                Password1Lab.Text = "No";
            }
        }

        private void LoginLab_ForeColorChanged(object sender, EventArgs e)
        {
            if(LoginLab.ForeColor==Color.IndianRed)
                CreateErrorMessage(0);
            else
                DeleteErrorMessage(0);
        }

        private void Password1Lab_ForeColorChanged(object sender, EventArgs e)
        {
            if(Password1Lab.ForeColor==Color.IndianRed)
                CreateErrorMessage(1);
            else
                DeleteErrorMessage(1);
        }

        private void Password2Lab_ForeColorChanged(object sender, EventArgs e)
        {
            if (Password2Lab.ForeColor == Color.IndianRed)
                CreateErrorMessage(2);
            else
                DeleteErrorMessage(2);
        }

        private void CreateUserBut_Click(object sender, EventArgs e)
        {
            if (TrueLogin && TruePassword && ComparePassword)
            {
                AllUsers.Add(new User(LoginTB.Text, Password1TB.Text));
                StreamWriter dat = new StreamWriter(@"cd..\\..\\..\\..\\Resources\\users.data");
                foreach (var u in AllUsers)
                    u.WriteOut(dat);
                dat.Close();
                MessageBox.Show("User " + LoginTB.Text + " has been created succesfully!");
                f.Show();
                Close();
            }
        }

    }
}
