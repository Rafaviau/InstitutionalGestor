using GestIn.Controllers;
using GestIn.Model;
using GestIn.Properties;
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
                if (result == DialogResult.Yes) {
                    var status = cntExamEnrol.unrolStudent(lbStudents.SelectedItem, exam);
                    updateUnenrolLabel(status.Item2,status.Item1);
                    if (status.Item1) lbStudents.Items.Remove(lbStudents.SelectedItem);
                }
            }
        }
        private async Task updateUnenrolLabel(string msg, bool success)
        {
            if (!success)
            {
                lblError.ForeColor = Color.IndianRed;
                lblError.Image = Resources.Error;
            }
            else
            {
                lblError.ForeColor = Color.FromArgb(75, 181, 67);
                lblError.Image = Resources.TickIcon;
            }
            lblError.Text = "         " + msg;
            lblError.Visible = true;
            await Task.Delay(2000);
            lblError.Visible = false;
        }
    }
}
