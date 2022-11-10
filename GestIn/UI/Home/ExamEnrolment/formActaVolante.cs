using GestIn.Controllers;
using GestIn.Model;
using GestIn.UI.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home.ExamEnrolment
{
    public partial class formActaVolante : Form
    {
        examEnrolmentController cntExamEnrol = examEnrolmentController.GetInstance();
        examController cntExam = examController.GetInstance();
        Exam exam;
        public formActaVolante(int IdExam)
        {
            InitializeComponent();
            exam = cntExam.findExam(IdExam);
            lblExam.Text = exam.IdSubjectNavigation.Name + " " + exam.Date.ToString("dd-MM-yyyy");
            foreach (var item in cntExamEnrol.getEnroledStudent(IdExam)) {
                lbStudents.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUnrol_Click(object sender, EventArgs e)
        {
            var std = (Student)lbStudents.SelectedItem;
            if (std != null) {
                var result = formConfirmation.ShowDialog(this, "¿Esta seguro que desea desinscribir este estudiante?",
                    ("El estudiante " +std.FullName()+ " sera dado de baja del examen de "+ exam.IdSubjectNavigation.Name));
                if (result == DialogResult.Yes) { MessageBox.Show("Yes"); }
                else { MessageBox.Show("No"); }
            }
            
        }
    }
}
