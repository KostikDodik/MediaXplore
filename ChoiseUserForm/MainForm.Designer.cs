namespace Media
{
    partial class MainForm
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
            this.WellLab = new System.Windows.Forms.Label();
            this.ChangeInfoBut = new System.Windows.Forms.Button();
            this.MusicBut = new System.Windows.Forms.Button();
            this.RefreshLibrBut = new System.Windows.Forms.Button();
            this.ChangeUserBut = new System.Windows.Forms.Button();
            this.CloseBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WellLab
            // 
            this.WellLab.AutoSize = true;
            this.WellLab.Font = new System.Drawing.Font("Matura MT Script Capitals", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WellLab.ForeColor = System.Drawing.Color.LawnGreen;
            this.WellLab.Location = new System.Drawing.Point(0, 0);
            this.WellLab.Name = "WellLab";
            this.WellLab.Size = new System.Drawing.Size(0, 39);
            this.WellLab.TabIndex = 1;
            // 
            // ChangeInfoBut
            // 
            this.ChangeInfoBut.BackgroundImage = global::Media.Properties.Resources.ChangeInfoBut;
            this.ChangeInfoBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeInfoBut.Location = new System.Drawing.Point(494, 38);
            this.ChangeInfoBut.Name = "ChangeInfoBut";
            this.ChangeInfoBut.Size = new System.Drawing.Size(40, 40);
            this.ChangeInfoBut.TabIndex = 5;
            this.ChangeInfoBut.UseVisualStyleBackColor = true;
            this.ChangeInfoBut.Click += new System.EventHandler(this.ChangeInfoBut_Click);
            // 
            // MusicBut
            // 
            this.MusicBut.BackgroundImage = global::Media.Properties.Resources.MusicBut;
            this.MusicBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MusicBut.Location = new System.Drawing.Point(109, 99);
            this.MusicBut.Name = "MusicBut";
            this.MusicBut.Size = new System.Drawing.Size(60, 60);
            this.MusicBut.TabIndex = 4;
            this.MusicBut.UseVisualStyleBackColor = true;
            this.MusicBut.Click += new System.EventHandler(this.MusicBut_Click);
            // 
            // RefreshLibrBut
            // 
            this.RefreshLibrBut.BackgroundImage = global::Media.Properties.Resources.RefrreshBut1;
            this.RefreshLibrBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshLibrBut.Location = new System.Drawing.Point(414, -1);
            this.RefreshLibrBut.Name = "RefreshLibrBut";
            this.RefreshLibrBut.Size = new System.Drawing.Size(40, 40);
            this.RefreshLibrBut.TabIndex = 3;
            this.RefreshLibrBut.UseVisualStyleBackColor = true;
            this.RefreshLibrBut.Click += new System.EventHandler(this.RefreshLibrBut_Click);
            // 
            // ChangeUserBut
            // 
            this.ChangeUserBut.BackgroundImage = global::Media.Properties.Resources.ChangeBut1;
            this.ChangeUserBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeUserBut.Location = new System.Drawing.Point(454, -1);
            this.ChangeUserBut.Name = "ChangeUserBut";
            this.ChangeUserBut.Size = new System.Drawing.Size(40, 40);
            this.ChangeUserBut.TabIndex = 2;
            this.ChangeUserBut.UseVisualStyleBackColor = true;
            this.ChangeUserBut.Click += new System.EventHandler(this.ChangeUserBut_Click);
            // 
            // CloseBut
            // 
            this.CloseBut.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseBut.BackgroundImage = global::Media.Properties.Resources.CloseBut1;
            this.CloseBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseBut.Location = new System.Drawing.Point(494, -1);
            this.CloseBut.Name = "CloseBut";
            this.CloseBut.Size = new System.Drawing.Size(40, 40);
            this.CloseBut.TabIndex = 0;
            this.CloseBut.UseVisualStyleBackColor = false;
            this.CloseBut.Click += new System.EventHandler(this.CloseBut_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 236);
            this.Controls.Add(this.ChangeInfoBut);
            this.Controls.Add(this.MusicBut);
            this.Controls.Add(this.RefreshLibrBut);
            this.Controls.Add(this.ChangeUserBut);
            this.Controls.Add(this.WellLab);
            this.Controls.Add(this.CloseBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "MediaXplore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.Label WellLab;
        private System.Windows.Forms.Button ChangeUserBut;
        private System.Windows.Forms.Button RefreshLibrBut;
        private System.Windows.Forms.Button MusicBut;
        private System.Windows.Forms.Button ChangeInfoBut;
    }
}