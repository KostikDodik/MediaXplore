using System;
using System.Diagnostics;
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
    public partial class TracksForm : Form
    {
        bool MousePress = false;
        Point position;
        User CurrentUser;
        List<MusicFile> Tracks = new List<MusicFile>();
        public TracksForm(User CurrentUser, List<MusicFile>Tracks,string labeltext)
        {
            InitializeComponent();
            this.CurrentUser = CurrentUser;
            this.label1.Text = labeltext;
            this.Location = new Point(this.Location.X, 50 * MusicMainForm.albumsformscount);
            MusicMainForm.albumsformscount++;
            this.Tracks = Tracks;
            foreach (var i in Tracks)
                TracksList.Items.Add(i.Name());
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            MusicMainForm.albumsformscount--;
            Close();
        }

        private void DragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MousePress = true;
            position = new Point(e.X, e.Y);

        }

        private void DragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (MousePress)
                this.DesktopLocation = new Point(MousePosition.X - position.X, MousePosition.Y - position.Y);
        }

        private void DragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            MousePress = false;
        }

        private void TracksList_DoubleClick(object sender, EventArgs e)
        {
            string wrt;
            Opener CurrentOpener=CurrentUser.SearchOpener(Tracks.Find(r=>r.Name()==TracksList.SelectedItem.ToString()).Type());
            MusicFile CurrentMusicFile=Tracks.Find(r => r.Name() == TracksList.SelectedItem.ToString());
            if (CurrentOpener == null)
                wrt = '"' + CurrentMusicFile.Address() + '"';
            else
                wrt = "start \"\" \"" + CurrentOpener.Address() + "\" \"" + CurrentMusicFile.Address() + "\"";
            Process pr= new Process();
            pr.StartInfo.FileName="cmd";
            pr.StartInfo.Arguments = "/C " + wrt;
            pr.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            pr.Start();
            pr.Close();
            pr.Dispose();
        }
    }
}
