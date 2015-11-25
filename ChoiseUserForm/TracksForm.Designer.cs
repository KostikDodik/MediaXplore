namespace Media
{
    partial class TracksForm
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
            this.CloseBut = new System.Windows.Forms.Button();
            this.DragPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TracksList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CloseBut
            // 
            this.CloseBut.BackgroundImage = global::Media.Properties.Resources.CloseBut2;
            this.CloseBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.DragPanel.Location = new System.Drawing.Point(0, 0);
            this.DragPanel.Name = "DragPanel";
            this.DragPanel.Size = new System.Drawing.Size(450, 20);
            this.DragPanel.TabIndex = 1;
            this.DragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseDown);
            this.DragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseMove);
            this.DragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragPanel_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 20F);
            this.label1.ForeColor = System.Drawing.Color.LawnGreen;
            this.label1.Location = new System.Drawing.Point(50, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 36);
            this.label1.TabIndex = 3;
            // 
            // TracksList
            // 
            this.TracksList.BackColor = System.Drawing.SystemColors.InfoText;
            this.TracksList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TracksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TracksList.ForeColor = System.Drawing.Color.LawnGreen;
            this.TracksList.FormattingEnabled = true;
            this.TracksList.ItemHeight = 20;
            this.TracksList.Location = new System.Drawing.Point(56, 59);
            this.TracksList.Name = "TracksList";
            this.TracksList.Size = new System.Drawing.Size(394, 260);
            this.TracksList.TabIndex = 4;
            this.TracksList.DoubleClick += new System.EventHandler(this.TracksList_DoubleClick);
            // 
            // TracksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.TracksList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DragPanel);
            this.Controls.Add(this.CloseBut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(450, 320);
            this.Name = "TracksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TracksForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBut;
        private System.Windows.Forms.Panel DragPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox TracksList;
    }
}