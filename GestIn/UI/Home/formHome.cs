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
using GestIn.UI.Home.Exams;
using GestIn.UI.Home.Subjects;
using GestIn.UI.Home.ExamEnrolment;
using GestIn.UI.Home.Users;

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
        private void munuBtnClick(object sender) {
            ChangeButtonColor(sender);
            hideSubmenus();
        }
        
        private void btnInicio_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
        }
        private void btnCarreras_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            AbrirFormularioHijo(new formCareer());
        }
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            AbrirFormularioHijo(new formSubject());
        }
        private void btnExams_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            AbrirFormularioHijo(new FormExams());
        }
        private void btnStudents_Click(object sender, EventArgs e)
        {
            munuBtnClick(sender);
            AbrirFormularioHijo(new formAcademicRecord());
        }
        private void btnEnrolments_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            subMenuToggle(panelSubmenuEnrolments);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            ChangeButtonColor(sender);
            AbrirFormularioHijo(new formUser());
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
        
        private void ChangeButtonColor(object sender)
        {
            btnCarreras.BackColor = Color.FromArgb(47, 49, 54);
            btnSubjects.BackColor = Color.FromArgb(47, 49, 54);
            btnInicio.BackColor = Color.FromArgb(47, 49, 54);
            btnStudents.BackColor = Color.FromArgb(47, 49, 54);
            btnExams.BackColor = Color.FromArgb(47, 49, 54);
            btnEnrolments.BackColor = Color.FromArgb(47, 49, 54);
            btnUsers.BackColor = Color.FromArgb(47, 49, 54);
            Button b = (Button)sender;
            b.BackColor = Color.FromArgb(114, 137, 218);
        }

        //Agregar futuros submenus aca
        private void hideSubmenus() {
            panelSubmenuEnrolments.Visible = false;
        }
        private void subMenuToggle(Panel panel) {
            if (panel.Visible == false) {
                hideSubmenus();
                panel.Visible = true;
            }
            else{
                panel.Visible = false;
            }
            
        }

        private void btnExamEnrolment_Click(object sender, EventArgs e)
        {
            hideSubmenus();
            AbrirFormularioHijo(new formExamEnrolmentAdmin());
        }
    }
}
