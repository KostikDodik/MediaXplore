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
    public partial class MusicMainForm : Form
    {
        public static int albumsformscount=0;
        User CurrentUser;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                result.ExStyle |= 0x02000000;
                return result;
            }
        }
        List<MusicFile> MusicFiles = new List<MusicFile>();
        List<string> Albums = new List<string>();
        List<string> Artists = new List<string>();
        LogForm f;
        public MusicMainForm(User CurrentUser,LogForm f)
        {
            InitializeComponent();
            ArtistsList.DrawMode = DrawMode.OwnerDrawVariable;
            LoadMusic();
            this.CurrentUser = CurrentUser;
            AlbumsList.Visible = false;
            foreach (var mf in MusicFiles)
            {
                if (Artists.FirstOrDefault(temp => mf.Tag().Artist() == temp) == null && mf.Tag().Artist()!=null)
                {
                    Artists.Add(mf.Tag().Artist());
                    ArtistsList.Items.Add(mf.Tag().Artist());
                }
            }
            ArtistsList.Items.Add(" No Artist");
            AlbumsList.Items.Add(" No Album");
            this.f = f;
            AlbumsList.Sorted = true;
            ArtistsList.Sorted = true;
        }

        private void RefreshBut_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter(@"cd..\\..\\..\\..\\Resources\\AllFiles.data", false);
            DirectoryInfo dir = new DirectoryInfo(@"D:\");
            Cursor = Cursors.WaitCursor;
            MessageBox.Show("Wait please");
            MainForm.GetFiles(dir, txt);
            txt.Close();
            Cursor = Cursors.Default;
            LoadMusic();      
        }
        
        public void LoadMusic()
        {
            MusicFiles.Clear();
            StreamReader text = new StreamReader(@"cd..\\..\\..\\..\\Resources\\AllFiles.data");
            while (!text.EndOfStream)
            {
                MusicFile tmp = new MusicFile(text.ReadLine());
                if (tmp.Type().Equals("mp3"))
                    MusicFiles.Add(tmp);
            }
            text.Close();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            f.Close();
        }

        private void ChangeUserBut_Click(object sender, EventArgs e)
        {
            f.Show();
            Close();
        }

        private void ArtistsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == ArtistsList.SelectedIndex)
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkCyan), e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),e.Font, new SolidBrush(Color.LawnGreen), e.Bounds,StringFormat.GenericDefault);
        }

        private void ArtistsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<MusicFile> CurrentArtistsMusic;
            if (ArtistsList.SelectedItem.ToString() != " No Artist")
                CurrentArtistsMusic = MusicFiles.FindAll(r => r.Tag().Artist() == ArtistsList.SelectedItem.ToString());
            else
                CurrentArtistsMusic = MusicFiles.FindAll(r => r.Tag().Artist() == null);
            string currentArtist = ArtistsList.SelectedItem.ToString();
            new AlbumsListForm(CurrentUser,CurrentArtistsMusic, currentArtist).Show();
        }

        private void ShowAlbumsBut_Click(object sender, EventArgs e)
        {
            label1.Text = "Albums";
            ArtistsList.Visible = false;
            foreach (var mf in MusicFiles)
            {
                if (Albums.FirstOrDefault(temp => mf.Tag().Album() == temp) == null && mf.Tag().Album() != null)
                {
                    Albums.Add(mf.Tag().Album());
                    AlbumsList.Items.Add(mf.Tag().Album());
                }
            }
            AlbumsList.Visible = true;

        }

        private void AlbumsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == AlbumsList.SelectedIndex)
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkCyan), e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(Color.LawnGreen), e.Bounds, StringFormat.GenericDefault);

        }

        private void ShowArtistsBut_Click(object sender, EventArgs e)
        {
            label1.Text = "Artists";
            AlbumsList.Visible = false;
            foreach (var mf in MusicFiles)
            {
                if (Artists.FirstOrDefault(temp => mf.Tag().Artist() == temp) == null && mf.Tag().Artist() != null)
                {
                    Artists.Add(mf.Tag().Artist());
                    ArtistsList.Items.Add(mf.Tag().Artist());
                }
            }
            ArtistsList.Visible = true;
        }

        private void AlbumsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<MusicFile> CurrentAlbumsMusic;
            if (AlbumsList.SelectedItem.ToString() != " No Album")
                CurrentAlbumsMusic = MusicFiles.FindAll(r => r.Tag().Album() == AlbumsList.SelectedItem.ToString());
            else
                CurrentAlbumsMusic = MusicFiles.FindAll(r => r.Tag().Album() == null);
            string currentArtist = AlbumsList.SelectedItem.ToString();
            new TracksForm(CurrentUser, CurrentAlbumsMusic, currentArtist).Show();
        }

    }
}
