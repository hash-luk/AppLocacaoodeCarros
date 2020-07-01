namespace Appdegerenciamentofuncionários
{
    partial class LoginForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginButton = new System.Windows.Forms.Button();
            this.SigninButton = new System.Windows.Forms.Button();
            this.PasswordImage = new System.Windows.Forms.PictureBox();
            this.UserLoginImage = new System.Windows.Forms.PictureBox();
            this.PasswordLabel = new System.Windows.Forms.TextBox();
            this.SupportImage = new System.Windows.Forms.PictureBox();
            this.ExitImage = new System.Windows.Forms.PictureBox();
            this.SupportLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.ForgotPasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Usertxb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupportImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.Control;
            this.LoginButton.Location = new System.Drawing.Point(6, 327);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 42);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SigninButton
            // 
            this.SigninButton.BackColor = System.Drawing.Color.Transparent;
            this.SigninButton.FlatAppearance.BorderSize = 0;
            this.SigninButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.SigninButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.SigninButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SigninButton.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Underline);
            this.SigninButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.SigninButton.Location = new System.Drawing.Point(133, 332);
            this.SigninButton.Name = "SigninButton";
            this.SigninButton.Size = new System.Drawing.Size(132, 33);
            this.SigninButton.TabIndex = 0;
            this.SigninButton.Text = "Cadastre-se";
            this.SigninButton.UseVisualStyleBackColor = true;
            this.SigninButton.Click += new System.EventHandler(this.SigninButton_Click);
            // 
            // PasswordImage
            // 
            this.PasswordImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordImage.BackColor = System.Drawing.Color.Transparent;
            this.PasswordImage.Enabled = false;
            this.PasswordImage.Image = ((System.Drawing.Image)(resources.GetObject("PasswordImage.Image")));
            this.PasswordImage.Location = new System.Drawing.Point(10, 235);
            this.PasswordImage.Name = "PasswordImage";
            this.PasswordImage.Size = new System.Drawing.Size(64, 64);
            this.PasswordImage.TabIndex = 1;
            this.PasswordImage.TabStop = false;
            // 
            // UserLoginImage
            // 
            this.UserLoginImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserLoginImage.BackColor = System.Drawing.Color.Transparent;
            this.UserLoginImage.Image = ((System.Drawing.Image)(resources.GetObject("UserLoginImage.Image")));
            this.UserLoginImage.Location = new System.Drawing.Point(10, 149);
            this.UserLoginImage.Name = "UserLoginImage";
            this.UserLoginImage.Size = new System.Drawing.Size(64, 64);
            this.UserLoginImage.TabIndex = 1;
            this.UserLoginImage.TabStop = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.HideSelection = false;
            this.PasswordLabel.Location = new System.Drawing.Point(80, 255);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.PasswordChar = '•';
            this.PasswordLabel.Size = new System.Drawing.Size(169, 23);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.WordWrap = false;
            // 
            // SupportImage
            // 
            this.SupportImage.BackColor = System.Drawing.Color.Transparent;
            this.SupportImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SupportImage.Image = ((System.Drawing.Image)(resources.GetObject("SupportImage.Image")));
            this.SupportImage.Location = new System.Drawing.Point(10, 390);
            this.SupportImage.Name = "SupportImage";
            this.SupportImage.Size = new System.Drawing.Size(32, 32);
            this.SupportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.SupportImage.TabIndex = 3;
            this.SupportImage.TabStop = false;
            this.SupportImage.Click += new System.EventHandler(this.SupportImage_Click);
            // 
            // ExitImage
            // 
            this.ExitImage.BackColor = System.Drawing.Color.Transparent;
            this.ExitImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitImage.Image = ((System.Drawing.Image)(resources.GetObject("ExitImage.Image")));
            this.ExitImage.Location = new System.Drawing.Point(217, 390);
            this.ExitImage.Name = "ExitImage";
            this.ExitImage.Size = new System.Drawing.Size(32, 32);
            this.ExitImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ExitImage.TabIndex = 3;
            this.ExitImage.TabStop = false;
            this.ExitImage.Click += new System.EventHandler(this.ExitImage_Click);
            // 
            // SupportLabel
            // 
            this.SupportLabel.AutoSize = true;
            this.SupportLabel.BackColor = System.Drawing.Color.Transparent;
            this.SupportLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SupportLabel.Location = new System.Drawing.Point(5, 429);
            this.SupportLabel.Name = "SupportLabel";
            this.SupportLabel.Size = new System.Drawing.Size(44, 13);
            this.SupportLabel.TabIndex = 4;
            this.SupportLabel.Text = "Suporte";
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.BackColor = System.Drawing.Color.Transparent;
            this.ExitLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitLabel.Location = new System.Drawing.Point(219, 429);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(24, 13);
            this.ExitLabel.TabIndex = 4;
            this.ExitLabel.Text = "Sair";
            // 
            // ForgotPasswordLinkLabel
            // 
            this.ForgotPasswordLinkLabel.AutoSize = true;
            this.ForgotPasswordLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPasswordLinkLabel.LinkColor = System.Drawing.Color.MediumOrchid;
            this.ForgotPasswordLinkLabel.Location = new System.Drawing.Point(81, 282);
            this.ForgotPasswordLinkLabel.Name = "ForgotPasswordLinkLabel";
            this.ForgotPasswordLinkLabel.Size = new System.Drawing.Size(92, 13);
            this.ForgotPasswordLinkLabel.TabIndex = 5;
            this.ForgotPasswordLinkLabel.TabStop = true;
            this.ForgotPasswordLinkLabel.Text = "Esqueceu a senha?";
            this.ForgotPasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPasswordLinkLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(65, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Usertxb
            // 
            this.Usertxb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Usertxb.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usertxb.Location = new System.Drawing.Point(84, 175);
            this.Usertxb.Name = "Usertxb";
            this.Usertxb.Size = new System.Drawing.Size(163, 23);
            this.Usertxb.TabIndex = 7;
            this.Usertxb.TextChanged += new System.EventHandler(this.Usertxb_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(259, 490);
            this.Controls.Add(this.Usertxb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForgotPasswordLinkLabel);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.SupportLabel);
            this.Controls.Add(this.ExitImage);
            this.Controls.Add(this.SupportImage);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UserLoginImage);
            this.Controls.Add(this.PasswordImage);
            this.Controls.Add(this.SigninButton);
            this.Controls.Add(this.LoginButton);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserLoginImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupportImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button SigninButton;
        private System.Windows.Forms.PictureBox PasswordImage;
        private System.Windows.Forms.PictureBox UserLoginImage;
        private System.Windows.Forms.TextBox PasswordLabel;
        private System.Windows.Forms.PictureBox SupportImage;
        private System.Windows.Forms.PictureBox ExitImage;
        private System.Windows.Forms.Label SupportLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.LinkLabel ForgotPasswordLinkLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Usertxb;
    }
}

