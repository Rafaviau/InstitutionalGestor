using GestIn.Controllers;
using GestIn.Model;
using GestIn.Properties;
using GestIn.Reports;
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
    public partial class formGradeFromExam : Form
    {
        examEnrolmentController cntExamEnrol = examEnrolmentController.GetInstance();
        examController cntExam = examController.GetInstance();
        gradeContorller gradeCnt = gradeContorller.GetInstance();
        subjectEnrolmentController subEnrolCnt = subjectEnrolmentController.GetInstance();
        Exam exam;
        public formGradeFromExam(int IdExam)
        {
            InitializeComponent();
            exam = cntExam.findExam(IdExam);
            lblExam.Text = exam.IdSubjectNavigation.Name + " " + exam.Date.ToString("dd-MM-yyyy");
            foreach (Student item in cntExamEnrol.getEnroledStudent(IdExam)) {
                addExam(item.Id,item.FullName());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnUnrol_Click(object sender, EventArgs e)
        {
            int stdId = (int)dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["studentId"].Value;
            string stdName = dgvStudents.Rows[dgvStudents.CurrentCell.RowIndex].Cells["name"].Value.ToString();
            if (stdId != null) {
                var result = formConfirmation.ShowDialog(this, "¿Esta seguro que desea desinscribir este estudiante?",
                    ("El estudiante " + stdName + " sera dado de baja del examen de "+ exam.IdSubjectNavigation.Name));
                if (result == DialogResult.Yes) {

                    var status = cntExamEnrol.unrolStudent(stdId, exam);
                    updateUnenrolLabel(status.Item2,status.Item1);
                    if (status.Item1) dgvStudents.Rows.RemoveAt(dgvStudents.SelectedRows[0].Index);


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
        private void addExam(int studentId,string name)
        {
            dgvStudents.Rows.Add(studentId,name);
        }

        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            var result = formConfirmation.ShowDialog(this, "¿Esta seguro que desea agregar notas?",
                    ("Se actualizaran TODAS las notas que no esten vacias"));
            if (result == DialogResult.Yes)
            {
                (bool,string) state = (true,"Notas cargadas correctamente");
                try
                {
                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        if (row.Cells["grade"].Value != null && row.Cells["bookRecord"].Value != null && row.Cells["bookRecord"].Value != "") {
                            if (!gradeCnt.addGrade(
                                  (int)row.Cells["studentId"].Value,
                                  exam.IdSubjectNavigation,
                                  Convert.ToInt32(row.Cells["grade"].Value),
                                  Convert.ToString(row.Cells["bookRecord"].Value),
                                  exam.Date,
                                  subEnrolCnt.getAcreditationTypeWithStudentId((int)row.Cells["studentId"].Value, exam.IdSubject)
                               ))
                                state = (false,"Error en la fila"+row.Index.ToString());
                        }
                    }
                    updateUnenrolLabel(state.Item2, state.Item1);
                }
                catch (Exception ex) { updateUnenrolLabel(ex.Message,false); }
            }

        }
    }
}
