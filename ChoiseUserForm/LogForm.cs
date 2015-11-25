using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Media
{
    public partial class LogForm : Form
    {
        User Empty = new User("","");
        User CurrentUser;
        List<User> AllUsers = new List<User>();        
        public LogForm()
        {
            StreamReader dat = new StreamReader(@"cd..\\..\\..\\..\\Resources\\users.data");
            while (!dat.EndOfStream)
            {
                User A=new User();
                A.ReadFrom(dat.ReadLine());
                AllUsers.Add(A);
            }
            dat.Close();
            InitializeComponent();
            this.CreateUserTT.SetToolTip(this.LogNewUserBut, "Create new user");
        }

        
        private void LogCloseBut_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogHelpBut_Click(object sender, EventArgs e)
        {
            new AboutForm().Show();
        }

        private void LogLoginBut_Click(object sender, EventArgs e)
        {
            LogLoginEntered();
        }

        private void LogLoginText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                LogLoginEntered();
        }

        private void LogPasswordText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                LogLoginEntered();
        }

        private void LogLoginEntered()
        {
            if (LogLoginText.TextLength > 0)
            {
                CurrentUser = Empty;
                string login = LogLoginText.Text;
                string pass = LogPasswordText.Text;
                foreach (var user in AllUsers)
                    if (login == user.Login() && user.ComparePassword(pass))
                        CurrentUser = user;
                if (CurrentUser.Equals(Empty))
                {
                    LogPasswordText.Text = "";
                    MessageBox.Show("Wrong username or password! Check it and try again!");
                }
                else
                {
                    LogForm f = this;
                    CurrentUser.ReadOpeners();
                    new MainForm(f,CurrentUser,AllUsers).Show();
                    this.Hide();
                }
            }
        }

        private void LogNewUserBut_Click(object sender, EventArgs e)
        {
            new CreateUserForm(this,AllUsers).Show();
            this.Hide();
        }                              
    }
}
