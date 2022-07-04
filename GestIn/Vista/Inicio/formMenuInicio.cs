using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Vista.Test;

namespace GestIn.Vista.Inicio
{
    public partial class formMenuInicio : Form
    {
        public formMenuInicio()
        {
            InitializeComponent();
            CustomizarSubMenu();
        }

        private void formMenuInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit(); 
        }
        private void CustomizarSubMenu() {
            panelSubmenuCarreras.Visible = false;
        }
        private void EsconderSubMenu()
        {
            if (panelSubmenuCarreras.Visible)
            {
                panelSubmenuCarreras.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel submenu)
        {
            if(submenu.Visible == false)
            {
                EsconderSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new formMateria());

            EsconderSubMenu();
        }
        #region Submenu Carreras
        private void btnCarreras_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelSubmenuCarreras);
        }

        private void btnAnalistaProgramador_Click(object sender, EventArgs e)
        {

            EsconderSubMenu();
        }

        private void btnServiciosGastronomicos_Click(object sender, EventArgs e)
        {

            EsconderSubMenu();
        }

        private void btnAcompañanteTerapeutico_Click(object sender, EventArgs e)
        {

            EsconderSubMenu();
        }

        private void btnIndustriasAgroalimentarias_Click(object sender, EventArgs e)
        {

            EsconderSubMenu();
        }

        private void btnTecnicaturaEnTurismo_Click(object sender, EventArgs e)
        {

            EsconderSubMenu();
        }

        private void btnEnfermeria_Click(object sender, EventArgs e)
        {

            EsconderSubMenu();
        }
        #endregion

        private Form formActivo = null;
        private void AbrirFormularioHijo(Form formHijo) {
            if(formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
    }
}
