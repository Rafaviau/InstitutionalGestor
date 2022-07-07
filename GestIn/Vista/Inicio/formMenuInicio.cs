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
        private Form formActivo = null;
        public formMenuInicio()
        {
            InitializeComponent();
        }

        private void formMenuInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit(); 
        }
        
        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new formMateria());
<<<<<<< HEAD
=======

            EsconderSubMenu();
>>>>>>> be5a5e07f214d262f38ecb9294d889f1b4adb445
        }
        private void btnCarreras_Click(object sender, EventArgs e)
        {

        }
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
