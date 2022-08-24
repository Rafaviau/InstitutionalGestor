namespace GestIn.UI.Login
{
    partial class formLogin
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.linkReportarError = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblInvalidData = new System.Windows.Forms.Label();
            this.btnViewPass = new System.Windows.Forms.PictureBox();
            this.linkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.linkRecuperarPassword = new System.Windows.Forms.LinkLabel();
            this.lblPasswordVacio = new System.Windows.Forms.Label();
            this.lblEmailVacio = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(410, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Image = global::GestIn.Properties.Resources.Minimize;
            this.btnMinimize.Location = new System.Drawing.Point(361, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::GestIn.Properties.Resources.Close;
            this.btnClose.Location = new System.Drawing.Point(387, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.panel2.Controls.Add(this.linkReportarError);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 580);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 18);
            this.panel2.TabIndex = 10;
            // 
            // linkReportarError
            // 
            this.linkReportarError.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkReportarError.AutoSize = true;
            this.linkReportarError.DisabledLinkColor = System.Drawing.Color.Black;
            this.linkReportarError.ForeColor = System.Drawing.Color.Black;
            this.linkReportarError.LinkColor = System.Drawing.Color.Black;
            this.linkReportarError.Location = new System.Drawing.Point(310, 0);
            this.linkReportarError.Name = "linkReportarError";
            this.linkReportarError.Size = new System.Drawing.Size(100, 15);
            this.linkReportarError.TabIndex = 6;
            this.linkReportarError.TabStop = true;
            this.linkReportarError.Text = "Reportar un error!";
            this.linkReportarError.VisitedLinkColor = System.Drawing.Color.Black;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.lblInvalidData);
            this.panel3.Controls.Add(this.btnViewPass);
            this.panel3.Controls.Add(this.linkRegistrarse);
            this.panel3.Controls.Add(this.linkRecuperarPassword);
            this.panel3.Controls.Add(this.lblPasswordVacio);
            this.panel3.Controls.Add(this.lblEmailVacio);
            this.panel3.Controls.Add(this.btnLogin);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Location = new System.Drawing.Point(12, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(386, 390);
            this.panel3.TabIndex = 11;
            // 
            // lblInvalidData
            // 
            this.lblInvalidData.AutoSize = true;
            this.lblInvalidData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvalidData.ForeColor = System.Drawing.Color.DarkGray;
            this.lblInvalidData.Image = global::GestIn.Properties.Resources.Error;
            this.lblInvalidData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInvalidData.Location = new System.Drawing.Point(34, 283);
            this.lblInvalidData.Name = "lblInvalidData";
            this.lblInvalidData.Size = new System.Drawing.Size(258, 17);
            this.lblInvalidData.TabIndex = 24;
            this.lblInvalidData.Text = "          Datos invalidos, intente nuevamente";
            this.lblInvalidData.Visible = false;
            // 
            // btnViewPass
            // 
            this.btnViewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.btnViewPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewPass.Image = global::GestIn.Properties.Resources.Eye;
            this.btnViewPass.Location = new System.Drawing.Point(352, 144);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(25, 25);
            this.btnViewPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnViewPass.TabIndex = 23;
            this.btnViewPass.TabStop = false;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // linkRegistrarse
            // 
            this.linkRegistrarse.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkRegistrarse.AutoSize = true;
            this.linkRegistrarse.ForeColor = System.Drawing.Color.Gray;
            this.linkRegistrarse.LinkColor = System.Drawing.Color.Gray;
            this.linkRegistrarse.Location = new System.Drawing.Point(14, 364);
            this.linkRegistrarse.Name = "linkRegistrarse";
            this.linkRegistrarse.Size = new System.Drawing.Size(99, 15);
            this.linkRegistrarse.TabIndex = 5;
            this.linkRegistrarse.TabStop = true;
            this.linkRegistrarse.Text = "Crear una cuenta";
            this.linkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistrarse_LinkClicked);
            // 
            // linkRecuperarPassword
            // 
            this.linkRecuperarPassword.ActiveLinkColor = System.Drawing.Color.DarkGray;
            this.linkRecuperarPassword.AutoSize = true;
            this.linkRecuperarPassword.DisabledLinkColor = System.Drawing.Color.Gray;
            this.linkRecuperarPassword.ForeColor = System.Drawing.Color.Gray;
            this.linkRecuperarPassword.LinkColor = System.Drawing.Color.Gray;
            this.linkRecuperarPassword.Location = new System.Drawing.Point(14, 334);
            this.linkRecuperarPassword.Name = "linkRecuperarPassword";
            this.linkRecuperarPassword.Size = new System.Drawing.Size(118, 15);
            this.linkRecuperarPassword.TabIndex = 4;
            this.linkRecuperarPassword.TabStop = true;
            this.linkRecuperarPassword.Text = "Olvide mi contraseña";
            this.linkRecuperarPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRecuperarPassword_LinkClicked);
            // 
            // lblPasswordVacio
            // 
            this.lblPasswordVacio.AutoSize = true;
            this.lblPasswordVacio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordVacio.ForeColor = System.Drawing.Color.DarkGray;
            this.lblPasswordVacio.Image = global::GestIn.Properties.Resources.Error;
            this.lblPasswordVacio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPasswordVacio.Location = new System.Drawing.Point(34, 182);
            this.lblPasswordVacio.Name = "lblPasswordVacio";
            this.lblPasswordVacio.Size = new System.Drawing.Size(254, 17);
            this.lblPasswordVacio.TabIndex = 20;
            this.lblPasswordVacio.Text = "          La contraseña no puede estar vacia";
            this.lblPasswordVacio.Visible = false;
            // 
            // lblEmailVacio
            // 
            this.lblEmailVacio.AutoSize = true;
            this.lblEmailVacio.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailVacio.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmailVacio.Image = global::GestIn.Properties.Resources.Error;
            this.lblEmailVacio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEmailVacio.Location = new System.Drawing.Point(34, 82);
            this.lblEmailVacio.Name = "lblEmailVacio";
            this.lblEmailVacio.Size = new System.Drawing.Size(214, 17);
            this.lblEmailVacio.TabIndex = 19;
            this.lblEmailVacio.Text = "          El email no puede estar vacio";
            this.lblEmailVacio.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(117, 229);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(153, 51);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GestIn.Properties.Resources.Password;
            this.pictureBox3.Location = new System.Drawing.Point(17, 144);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 25);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(65, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.Location = new System.Drawing.Point(65, 144);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(281, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.WordWrap = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GestIn.Properties.Resources.Email;
            this.pictureBox2.Location = new System.Drawing.Point(17, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(65, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtEmail.Location = new System.Drawing.Point(65, 44);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(281, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.WordWrap = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(150, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 42);
            this.label5.TabIndex = 12;
            this.label5.Text = "Login";
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(410, 598);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLogin";
            this.Text = "formLogin";
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formLogin_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnViewPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private LinkLabel linkRegistrarse;
        private LinkLabel linkRecuperarPassword;
        private Label lblPasswordVacio;
        private Label lblEmailVacio;
        private Button btnLogin;
        private PictureBox pictureBox3;
        private Label label2;
        private TextBox txtPassword;
        private PictureBox pictureBox2;
        private Label label1;
        private TextBox txtEmail;
        private LinkLabel linkReportarError;
        private PictureBox btnClose;
        private PictureBox btnMinimize;
        private PictureBox btnViewPass;
        private Label label5;
        private Label lblInvalidData;
    }
}