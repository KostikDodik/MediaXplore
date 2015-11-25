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
    public partial class ChangeInfoForm : Form
    {
        LogForm f;
        User CurrentUser;
        string openersway;
        List<User> AllUsers;
        public ChangeInfoForm(LogForm f,User CurrUser,List<User> AllUsers)
        {
            InitializeComponent();
            CurrentUser = CurrUser;
            this.f = f;
            this.AllUsers = AllUsers;
        }
        private void CloseBut_Click(object sender, EventArgs e)
        {
            new MainForm(f,CurrentUser,AllUsers).Show();
            Close();
        }

        private void RewriteUsersData()
        {
                StreamWriter dat = new StreamWriter(@"cd..\\..\\..\\..\\Resources\\users.data");
                foreach (var u in AllUsers)
                    u.WriteOut(dat);
                dat.Close();
        }

        private void AplyInfoBut_Click(object sender, EventArgs e)
        {
            if (LoginTB.Text.Length > 0)
            {
                if (CurrentUser.ComparePassword(OldPassTB.Text))
                {
                    bool can = true;
                    foreach (var u in AllUsers)
                        if (u.Login() == LoginTB.Text && u != CurrentUser)
                        {
                            can = false;
                            break;
                        }
                    if (can)
                    {
                        string tmp = CurrentUser.Login();
                        CurrentUser.SetLogin(LoginTB.Text);
                        RewriteUsersData();
                        MessageBox.Show("User " + tmp + " has been succesfully renamed to " + LoginTB.Text + "!");
                    }
                    else
                    {
                        MessageBox.Show("Sorry, but this login already exists");
                        LoginTB.Text = "";
                        OldPassTB.Text = "";
                    }
                }
            }
            if (NewPassTB.Text.Length > 7)
            {
                if (ConfirmPassTB.Text == NewPassTB.Text)
                {
                    CurrentUser.SetPassword(NewPassTB.Text);
                    RewriteUsersData();
                    MessageBox.Show("Password changed succesfully!");
                }
                else
                {
                    MessageBox.Show("Passwords are not equal!");
                    NewPassTB.Text = "";
                    ConfirmPassTB.Text = "";
                }
            }
            else if(NewPassTB.Text.Length >0)
            {
                MessageBox.Show("Password must be longer than 7 symbols!");
                NewPassTB.Text = "";
                ConfirmPassTB.Text = "";
            }
        }

        private void ChooseFileBut_Click(object sender, EventArgs e)
        {
            OpenFileDialog openers = new OpenFileDialog();
            if (openers.ShowDialog()==DialogResult.OK)
                openersway=openers.FileName;
        }

        private void AddProgramBut_Click(object sender, EventArgs e)
        {
            Opener a = new Opener();
            a.SetAddress(openersway);
            a.SetName(ProgramNameTB.Text);
            a.SetTypeOfFile(TypeOfFileTB.Text);
            CurrentUser.AddOrChangeOpener(a);
            CurrentUser.WriteOutOpeners();
        }
    }
}
