using System;
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
    public partial class AlbumsListForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams result = base.CreateParams;
                result.ExStyle |= 0x02000000;
                return result;
            }
        }
        List<MusicFile> CurrentArtistsMusic = new List<MusicFile>();
        bool MousePress = false;
        User CurrentUser;
        Point position;
        List<string> Albums = new List<string>();
        public AlbumsListForm(User CurrentUser, List<MusicFile> CurrentArtistsMusic, string currentArtist)
        {
            InitializeComponent();
            this.Location = new Point(this.Location.X, this.Location.Y + 50*MusicMainForm.albumsformscount);
            MusicMainForm.albumsformscount++;
            this.CurrentArtistsMusic=CurrentArtistsMusic;
            this.CurrentUser = CurrentUser;
            ArtistLab.Text = currentArtist;
            AlbumsList.DrawMode = DrawMode.OwnerDrawVariable;
            foreach (var mf in CurrentArtistsMusic)
            {
                if (Albums.FirstOrDefault(temp => mf.Tag().Album() == temp) == null && mf.Tag().Album() != null)
                {
                    AlbumsList.Items.Add(mf.Tag().Album());
                    Albums.Add(mf.Tag().Album());
                }
            }
            AlbumsList.Items.Add(" No Album");
            AlbumsList.Sorted = true;
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            MusicMainForm.albumsformscount--;
            Close();
        }

        private void AlbumsList_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == AlbumsList.SelectedIndex)
                e.Graphics.FillRectangle(new SolidBrush(Color.DarkCyan), e.Bounds);
            e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(), e.Font, new SolidBrush(Color.LawnGreen), e.Bounds, StringFormat.GenericDefault);

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

        private void AlbumsList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            List<MusicFile> CurrentAlbumsMusic;
            if (AlbumsList.SelectedItem.ToString() != " No Album")
                CurrentAlbumsMusic = CurrentArtistsMusic.FindAll(r => r.Tag().Album() == AlbumsList.SelectedItem.ToString());
            else
                CurrentAlbumsMusic = CurrentArtistsMusic.FindAll(r => r.Tag().Album() == null);
            string currentAlbum =CurrentAlbumsMusic[0].Tag().Album();
            new TracksForm(CurrentUser, CurrentAlbumsMusic, currentAlbum).Show();
        }

    }
}
