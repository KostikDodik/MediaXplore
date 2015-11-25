using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media
{
    public partial class MainForm : Form
    {
        List<File> AllFiles = new List<File>();
        LogForm f;
        User CurrentUser;
        List<User> AllUsers;
        public MainForm(LogForm f, User CurrUser,List<User>AllUsers)
        {
            InitializeComponent();
            this.f = f;
            this.CurrentUser = CurrUser;
            this.AllUsers = AllUsers;
            WellLab.Text = "Wellcome, " + CurrentUser.Login() + "!";
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            f.Close();
        }

        private void ChangeUserBut_Click(object sender, EventArgs e)
        {
            f.Show();
            this.Close();
        }

        public static void GetFiles(DirectoryInfo dir, TextWriter txt)
        {
                try
                {
                    FileInfo[] files = dir.GetFiles();
                    foreach (FileInfo f in files)
                    {
                        if (f.Name.Substring(f.Name.Length - 4).Equals(".mp3") || f.Name.Substring(f.Name.Length - 4).Equals(".aac") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".ac3") || f.Name.Substring(f.Name.Length - 4).Equals(".fla") ||
                            f.Name.Substring(f.Name.Length - 5).Equals(".flac") || f.Name.Substring(f.Name.Length - 4).Equals(".m4a") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".m4b") || f.Name.Substring(f.Name.Length - 4).Equals(".wav") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".wma") || f.Name.Substring(f.Name.Length - 4).Equals(".pls") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".cue") || f.Name.Substring(f.Name.Length - 4).Equals(".m3u") ||//music
                            f.Name.Substring(f.Name.Length - 4).Equals(".avi") || f.Name.Substring(f.Name.Length - 5).Equals(".divx") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".mp4") || f.Name.Substring(f.Name.Length - 4).Equals(".flv") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".mp3") || f.Name.Substring(f.Name.Length - 4).Equals(".wmv") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".mpg") || f.Name.Substring(f.Name.Length - 4).Equals(".m4v") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".mkv") || f.Name.Substring(f.Name.Length - 4).Equals(".swf") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".flv") || f.Name.Substring(f.Name.Length - 4).Equals(".gom") ||
                            f.Name.Substring(f.Name.Length - 4).Equals(".mqv") || f.Name.Substring(f.Name.Length - 4).Equals(".mov"))//video
                            txt.WriteLine(f.FullName + "\t" + f.Length + "\t" + f.Name.Substring(0, f.Name.LastIndexOf('.')) + "\t" + f.Name.Substring(f.Name.LastIndexOf('.') + 1));
                        //Address Size name type
                        GC.AddMemoryPressure(1000);
                    }
                }
                catch (Exception erorchik)
                {
                    Console.WriteLine(erorchik.Message);
                }
                try
                {
                    foreach (DirectoryInfo d in dir.GetDirectories())
                        GetFiles(d, txt);
                }
                catch (Exception erorchik)
                {
                    Console.WriteLine(erorchik.Message);
                }
        }

        private void RefreshLibrBut_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(@"cd..\\..\\..\\..\\Resources\\AllFiles.data", false);
            DirectoryInfo dir = new DirectoryInfo(@"D:\");
            Cursor = Cursors.WaitCursor;
            MessageBox.Show("Wait please");
            GetFiles(dir, txt);
            txt.Close();
            Cursor = Cursors.Default;
        }

        private void MusicBut_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            new MusicMainForm(CurrentUser,f).Show();
            Close();
        }

        private void ChangeInfoBut_Click(object sender, EventArgs e)
        {
            new ChangeInfoForm(f,CurrentUser,AllUsers).Show();
            Close();
        }
    }
}
