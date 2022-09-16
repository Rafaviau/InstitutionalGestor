using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using GestIn.Controllers;
using GestIn.Vista.Home;

namespace GestIn.Vista.Login
{
    public partial class formLogin : Form
    {
        userController cntUser = userController.GetInstance();
        public formLogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
       
        #region "Minimizar,cerrar y arrastrar"
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void formLogin_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.Text = "Cargando...";
            
            if (txtEmail.Text.Equals("")) { lblEmailVacio.Visible = true; }
            else{  lblEmailVacio.Visible = false;}
            if (txtPassword.Text.Equals("")) { lblPasswordVacio.Visible = true; }
            else { lblPasswordVacio.Visible = false; }
            if (!txtEmail.Text.Equals("") && !txtPassword.Text.Equals("")) {
                if (cntUser.verifyLogin(txtEmail.Text, txtPassword.Text)){
                    this.Visible = false;
                    formHome formHome = new formHome();
                    formHome.Show();
                }
                else {
                    lblInvalidData.Visible = true;
                }
            }
            btnLogin.Text = "Login";
            
        }

        private void linkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formStudentEnroment formRegistroAlumno = new formStudentEnroment();
            formRegistroAlumno.ShowDialog();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkRecuperarPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formRecoverPass formRecuperarPassword = new formRecoverPass();
            formRecuperarPassword.ShowDialog();
        }
    }
}
