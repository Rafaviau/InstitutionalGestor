using GestIn.UI.Home.Students;
using GestIn.UI.Home.Careers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home
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
            ChangeButtonColor(sender);
        }
        private void btnCarreras_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new formCareer());
            ChangeButtonColor(sender);
        }

        private void AbrirFormularioHijo(Form formHijo) {
            if(formActivo != null)
            {
                formActivo.Dispose();
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

        private void btnStudents_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            AbrirFormularioHijo(new formAcademicRecord());
        }
        private void ChangeButtonColor(object sender)
        {
            btnCarreras.BackColor = Color.FromArgb(47, 49, 54);
            btnInicio.BackColor = Color.FromArgb(47, 49, 54);
            btnStudents.BackColor = Color.FromArgb(47, 49, 54);
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(114, 137, 218);
        }
    }
}
