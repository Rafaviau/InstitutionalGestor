﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.Vista.Home
{
    public partial class formHome : Form
    {
        private Form formActivo = null;
        public formHome()
        {
            InitializeComponent();
        }

        private void formMenuInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
                Application.Exit(); 
        }
        
        private void btnInicio_Click(object sender, EventArgs e)
        {
            //Abrir hijo
            //AbrirFormularioHijo(new formMateria());
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