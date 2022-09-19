using GestIn.UI.Test;
using GestIn.Vista.Home.Grades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home.Grades
{
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            TempStudentCreate formRegistroAlumno = new TempStudentCreate();
            formRegistroAlumno.ShowDialog();
        }

        private void btnAddCareer_Click(object sender, EventArgs e)
        {
            formCareer thisformCareer = new formCareer();
            thisformCareer.ShowDialog();
        }

        private void addGrade_Click(object sender, EventArgs e)
        {
            formGrades formGrade = new formGrades();
            formGrade.ShowDialog();
        }
    }
}
