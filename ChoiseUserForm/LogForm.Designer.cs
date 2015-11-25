namespace Media
{
    partial class LogForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LogMeetingLab = new System.Windows.Forms.Label();
            this.LogPasswordText = new System.Windows.Forms.TextBox();
            this.LogLoginText = new System.Windows.Forms.TextBox();
            this.LogPasswordLab = new System.Windows.Forms.Label();
            this.LogLoginLab = new System.Windows.Forms.Label();
            this.LogNewUserBut = new System.Windows.Forms.Button();
            this.LogLoginBut = new System.Windows.Forms.Button();
            this.LogAboutBut = new System.Windows.Forms.Button();
            this.LogCloseBut = new System.Windows.Forms.Button();
            this.CreateUserTT = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // LogMeetingLab
            // 
            this.LogMeetingLab.AutoSize = true;
            this.LogMeetingLab.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogMeetingLab.ForeColor = System.Drawing.Color.LawnGreen;
            this.LogMeetingLab.Location = new System.Drawing.Point(46, 45);
            this.LogMeetingLab.Name = "LogMeetingLab";
            this.LogMeetingLab.Size = new System.Drawing.Size(435, 28);
            this.LogMeetingLab.TabIndex = 0;
            this.LogMeetingLab.Text = "Nice to see you in our manager!";
            // 
            // LogPasswordText
            // 
            this.LogPasswordText.Location = new System.Drawing.Point(197, 117);
            this.LogPasswordText.Name = "LogPasswordText";
            this.LogPasswordText.Size = new System.Drawing.Size(138, 20);
            this.LogPasswordText.TabIndex = 2;
            this.LogPasswordText.UseSystemPasswordChar = true;
            this.LogPasswordText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogPasswordText_KeyDown);
            // 
            // LogLoginText
            // 
            this.LogLoginText.Location = new System.Drawing.Point(197, 91);
            this.LogLoginText.Name = "LogLoginText";
            this.LogLoginText.Size = new System.Drawing.Size(138, 20);
            this.LogLoginText.TabIndex = 1;
            this.LogLoginText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LogLoginText_KeyDown);
            // 
            // LogPasswordLab
            // 
            this.LogPasswordLab.AutoSize = true;
            this.LogPasswordLab.Font = new System.Drawing.Font("Matura MT Script Capitals", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogPasswordLab.ForeColor = System.Drawing.Color.LawnGreen;
            this.LogPasswordLab.Location = new System.Drawing.Point(48, 117);
            this.LogPasswordLab.Name = "LogPasswordLab";
            this.LogPasswordLab.Size = new System.Drawing.Size(141, 25);
            this.LogPasswordLab.TabIndex = 5;
            this.LogPasswordLab.Text = "Enter password";
            // 
            // LogLoginLab
            // 
            this.LogLoginLab.AutoSize = true;
            this.LogLoginLab.Font = new System.Drawing.Font("Matura MT Script Capitals", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLoginLab.ForeColor = System.Drawing.Color.LawnGreen;
            this.LogLoginLab.Location = new System.Drawing.Point(76, 91);
            this.LogLoginLab.Name = "LogLoginLab";
            this.LogLoginLab.Size = new System.Drawing.Size(113, 28);
            this.LogLoginLab.TabIndex = 6;
            this.LogLoginLab.Text = "Enter login";
            // 
            // LogNewUserBut
            // 
            this.LogNewUserBut.BackgroundImage = global::Media.Properties.Resources.NewUserBut;
            this.LogNewUserBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.LogNewUserBut.Location = new System.Drawing.Point(393, 91);
            this.LogNewUserBut.Name = "LogNewUserBut";
            this.LogNewUserBut.Size = new System.Drawing.Size(46, 46);
            this.LogNewUserBut.TabIndex = 7;
            this.LogNewUserBut.UseVisualStyleBackColor = true;
            this.LogNewUserBut.Click += new System.EventHandler(this.LogNewUserBut_Click);
            // 
            // LogLoginBut
            // 
            this.LogLoginBut.BackgroundImage = global::Media.Properties.Resources.LoginBut;
            this.LogLoginBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogLoginBut.Location = new System.Drawing.Point(341, 91);
            this.LogLoginBut.Name = "LogLoginBut";
            this.LogLoginBut.Size = new System.Drawing.Size(46, 46);
            this.LogLoginBut.TabIndex = 3;
            this.LogLoginBut.UseVisualStyleBackColor = true;
            this.LogLoginBut.Click += new System.EventHandler(this.LogLoginBut_Click);
            // 
            // LogAboutBut
            // 
            this.LogAboutBut.BackgroundImage = global::Media.Properties.Resources.HelpBut1;
            this.LogAboutBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogAboutBut.Location = new System.Drawing.Point(453, -1);
            this.LogAboutBut.Name = "LogAboutBut";
            this.LogAboutBut.Size = new System.Drawing.Size(40, 40);
            this.LogAboutBut.TabIndex = 4;
            this.LogAboutBut.UseVisualStyleBackColor = true;
            this.LogAboutBut.Click += new System.EventHandler(this.LogHelpBut_Click);
            // 
            // LogCloseBut
            // 
            this.LogCloseBut.BackgroundImage = global::Media.Properties.Resources.CloseBut1;
            this.LogCloseBut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogCloseBut.ForeColor = System.Drawing.Color.Yellow;
            this.LogCloseBut.Location = new System.Drawing.Point(494, -1);
            this.LogCloseBut.Name = "LogCloseBut";
            this.LogCloseBut.Size = new System.Drawing.Size(40, 40);
            this.LogCloseBut.TabIndex = 5;
            this.LogCloseBut.UseVisualStyleBackColor = true;
            this.LogCloseBut.Click += new System.EventHandler(this.LogCloseBut_Click);
            // 
            // CreateUserTT
            // 
            this.CreateUserTT.AutomaticDelay = 100;
            this.CreateUserTT.AutoPopDelay = 10000;
            this.CreateUserTT.InitialDelay = 100;
            this.CreateUserTT.ReshowDelay = 20;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(537, 236);
            this.Controls.Add(this.LogNewUserBut);
            this.Controls.Add(this.LogLoginBut);
            this.Controls.Add(this.LogLoginLab);
            this.Controls.Add(this.LogPasswordLab);
            this.Controls.Add(this.LogLoginText);
            this.Controls.Add(this.LogPasswordText);
            this.Controls.Add(this.LogAboutBut);
            this.Controls.Add(this.LogCloseBut);
            this.Controls.Add(this.LogMeetingLab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Media xplore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogMeetingLab;
        private System.Windows.Forms.Button LogCloseBut;
        private System.Windows.Forms.Button LogAboutBut;
        private System.Windows.Forms.TextBox LogPasswordText;
        private System.Windows.Forms.TextBox LogLoginText;
        private System.Windows.Forms.Label LogPasswordLab;
        private System.Windows.Forms.Label LogLoginLab;
        private System.Windows.Forms.Button LogLoginBut;
        private System.Windows.Forms.Button LogNewUserBut;
        private System.Windows.Forms.ToolTip CreateUserTT;
    }
}

