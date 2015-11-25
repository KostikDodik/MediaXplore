namespace Media
{
    partial class AlbumsListForm
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
            this.AlbumsList = new System.Windows.Forms.ListBox();
            this.ArtistLab = new System.Windows.Forms.Label();
            this.CloseBut = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // AlbumsList
            // 
            this.AlbumsList.BackColor = System.Drawing.SystemColors.InfoText;
            this.AlbumsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AlbumsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AlbumsList.FormattingEnabled = true;
            this.AlbumsList.ItemHeight = 20;
            this.AlbumsList.Location = new System.Drawing.Point(70, 59);
            this.AlbumsList.Name = "AlbumsList";
            this.AlbumsList.Size = new System.Drawing.Size(380, 260);
            this.AlbumsList.TabIndex = 1;
            this.AlbumsList.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.AlbumsList_DrawItem);
            this.AlbumsList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.AlbumsList_MouseDoubleClick);
            // 
            // ArtistLab
            // 
            this.ArtistLab.AutoSize = true;
            this.ArtistLab.Font = new System.Drawing.Font("Matura MT Script Capitals", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArtistLab.ForeColor = System.Drawing.Color.LawnGreen;
            this.ArtistLab.Location = new System.Drawing.Point(56, 20);
            this.ArtistLab.Name = "ArtistLab";
            this.ArtistLab.Size = new System.Drawing.Size(0, 36);
            this.ArtistLab.TabIndex = 2;
            // 
            // CloseBut
            // 
            this.CloseBut.BackgroundImage = global::Media.Properties.Resources.CloseBut2;
            this.CloseBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBut.Location = new System.Drawing.Point(0, 20);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(50, 300);
            this.CloseBut.TabIndex = 0;
            this.CloseBut.UseVisualStyleBackColor = true;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // DragPanel
            // 
            this.DragPanel.BackColor = System.Drawing.Color.Yellow;
            this.DragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(450, 20);
            this.DragPanel.TabIndex = 3;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // AlbumsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.ArtistLab);
            this.Controls.Add(this.AlbumsList);
            this.Controls.Add(this.CloseBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(450, 0);
            this.Name = "AlbumsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AlbumsListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.ListBox AlbumsList;
        private System.Windows.Forms.Label ArtistLab;
        private System.Windows.Forms.Panel DragPanel;
    }
}