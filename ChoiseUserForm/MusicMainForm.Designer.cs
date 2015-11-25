namespace Media
{
    partial class MusicMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicMainForm));
            this.TopTS = new System.Windows.Forms.ToolStrip();
            this.CloseBut = new System.Windows.Forms.ToolStripButton();
            this.RefreshBut = new System.Windows.Forms.ToolStripButton();
            this.ChangeUserBut = new System.Windows.Forms.ToolStripButton();
            this.ShowAlbumsBut = new System.Windows.Forms.ToolStripButton();
            this.ShowArtistsBut = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.ArtistsList = new System.Windows.Forms.ListBox();
            this.AlbumsList = new System.Windows.Forms.ListBox();
            this.TopTS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopTS
            // 
            this.TopTS.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopTS.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.TopTS.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.TopTS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CloseBut,
            this.RefreshBut,
            this.ChangeUserBut,
            this.ShowAlbumsBut,
            this.ShowArtistsBut});
            this.TopTS.Location = new System.Drawing.Point(0, 0);
            this.TopTS.Name = "TopTS";
            this.TopTS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TopTS.Size = new System.Drawing.Size(450, 47);
            this.TopTS.TabIndex = 0;
            this.TopTS.Text = "toolStrip1";
            // 
            // CloseBut
            // 
            this.CloseBut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBut.BackgroundImage")));
            this.CloseBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CloseBut.Image = ((System.Drawing.Image)(resources.GetObject("CloseBut.Image")));
            this.CloseBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(44, 44);
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // RefreshBut
            // 
            this.RefreshBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshBut.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBut.Image")));
            this.RefreshBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshBut.Name = "RefreshBut";
            this.RefreshBut.Size = new System.Drawing.Size(44, 44);
            this.RefreshBut.Text = "Refresh music library";
            this.RefreshBut.Click += new System.EventHandler(this.RefreshBut_Click);
            // 
            // ChangeUserBut
            // 
            this.ChangeUserBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChangeUserBut.Image = ((System.Drawing.Image)(resources.GetObject("ChangeUserBut.Image")));
            this.ChangeUserBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChangeUserBut.Name = "ChangeUserBut";
            this.ChangeUserBut.Size = new System.Drawing.Size(44, 44);
            this.ChangeUserBut.Text = "Change User";
            this.ChangeUserBut.Click += new System.EventHandler(this.ChangeUserBut_Click);
            // 
            // ShowAlbumsBut
            // 
            this.ShowAlbumsBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowAlbumsBut.Image = ((System.Drawing.Image)(resources.GetObject("ShowAlbumsBut.Image")));
            this.ShowAlbumsBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowAlbumsBut.Name = "ShowAlbumsBut";
            this.ShowAlbumsBut.Size = new System.Drawing.Size(44, 44);
            this.ShowAlbumsBut.Text = "Show all Albums";
            this.ShowAlbumsBut.Click += new System.EventHandler(this.ShowAlbumsBut_Click);
            // 
            // ShowArtistsBut
            // 
            this.ShowArtistsBut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ShowArtistsBut.Image = global::Media.Properties.Resources.ArtistBut;
            this.ShowArtistsBut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ShowArtistsBut.Name = "ShowArtistsBut";
            this.ShowArtistsBut.Size = new System.Drawing.Size(44, 44);
            this.ShowArtistsBut.Text = "Show all artists";
            this.ShowArtistsBut.Click += new System.EventHandler(this.ShowArtistsBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(0, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artists:";
            // 
            // ArtistsList
            // 
            this.ArtistsList.BackColor = System.Drawing.SystemColors.InfoText;
            this.ArtistsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ArtistsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArtistsList.ForeColor = System.Drawing.Color.LawnGreen;
            this.ArtistsList.FormattingEnabled = true;
            this.ArtistsList.ItemHeight = 20;
            this.ArtistsList.Location = new System.Drawing.Point(20, 86);
            this.ArtistsList.Name = "ArtistsList";
            this.ArtistsList.Size = new System.Drawing.Size(430, 640);
            this.ArtistsList.TabIndex = 1;
            this.ArtistsList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ArtistsList_DrawItem);
            this.ArtistsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ArtistsList_MouseDoubleClick);
            // 
            // AlbumsList
            // 
            this.AlbumsList.BackColor = System.Drawing.SystemColors.InfoText;
            this.AlbumsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlbumsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlbumsList.ForeColor = System.Drawing.Color.LawnGreen;
            this.AlbumsList.FormattingEnabled = true;
            this.AlbumsList.ItemHeight = 20;
            this.AlbumsList.Location = new System.Drawing.Point(20, 86);
            this.AlbumsList.Name = "AlbumsList";
            this.AlbumsList.Size = new System.Drawing.Size(430, 640);
            this.AlbumsList.TabIndex = 3;
            this.AlbumsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AlbumsList_MouseDoubleClick);
            // 
            // MusicMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 736);
            this.Controls.Add(this.AlbumsList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ArtistsList);
            this.Controls.Add(this.TopTS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MusicMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MusicForm";
            this.TopTS.ResumeLayout(false);
            this.TopTS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TopTS;
        private System.Windows.Forms.ToolStripButton RefreshBut;
        private System.Windows.Forms.ToolStripButton ShowAlbumsBut;
        private System.Windows.Forms.ToolStripButton CloseBut;
        private System.Windows.Forms.ToolStripButton ChangeUserBut;
        private System.Windows.Forms.ListBox ArtistsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton ShowArtistsBut;
        private System.Windows.Forms.ListBox AlbumsList;
    }
}