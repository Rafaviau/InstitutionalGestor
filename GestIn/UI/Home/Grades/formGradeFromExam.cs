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
        string bookRecordPresential;
        string bookRecordFree;
        public formGradeFromExam(int IdExam)
        {
            InitializeComponent();
            exam = cntExam.findExam(IdExam);
            lblExam.Text = exam.IdSubjectNavigation.Name + " " + exam.Date.ToString("dd-MM-yyyy");
            foreach (Student item in cntExamEnrol.getEnroledStudent(IdExam)) {
                addExam(item);
            }
            txtFreeBook.Text = bookRecordFree;
            txtPresentialBook.Text = bookRecordPresential;
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
        private void addExam(Student std)
        {
            try {
                var grade = gradeCnt.getStudentGradeForExams(std.Id, exam.IdSubject, exam.Date);
                var accType = subEnrolCnt.getAcreditationType(std.User.Dni, exam.IdSubject);
                if (grade.Grade1 == -1)
                    dgvStudents.Rows.Add(std.Id, std.User.fullName(), accType, "AUSENTE");
                else
                    dgvStudents.Rows.Add(std.Id, std.User.fullName(), accType, grade?.Grade1);
                if (accType == "Presencial" && grade != null)
                    bookRecordPresential = grade.BookRecord;
                if (accType == "Libre" && grade != null)
                    bookRecordFree = grade.BookRecord;
            }
            catch (Exception ex) {
                updateUnenrolLabel(ex.Message, false);
            }
        }
        private void btnAddGrades_Click(object sender, EventArgs e)
        {
            int _grade;
            string bookRecord;
            var result = formConfirmation.ShowDialog(this, "¿Esta seguro que desea agregar notas?",
                    ("Se actualizaran TODAS las notas."));
            if (result == DialogResult.Yes)
            {
                (bool,string) state = (true,"Notas cargadas correctamente");
                try
                {
                    foreach (DataGridViewRow row in dgvStudents.Rows)
                    {
                        _grade = -1;

                        if (row.Cells["condition"].Value.ToString() == "Libre")
                            bookRecord = txtFreeBook.Text;
                        else
                            bookRecord = txtPresentialBook.Text;

                        if (row.Cells["grade"].Value != "AUSENTE" && row.Cells["grade"].Value != null)
                            _grade = Convert.ToInt32(row.Cells["grade"].Value);

                        Grade grade = gradeCnt.getStudentGradeForExams(
                                        (int)row.Cells["studentId"].Value,
                                        exam.IdSubject,
                                        (DateTime)exam.Date
                                        );

                        if (grade == null)
                        {
                            if (!gradeCnt.addGrade(
                                (int)row.Cells["studentId"].Value,
                                exam.IdSubjectNavigation,
                                _grade,
                                bookRecord,
                                exam.Date,
                                subEnrolCnt.getAcreditationTypeWithStudentId((int)row.Cells["studentId"].Value, exam.IdSubject)
                            ))
                                state = (false, "Error en la fila" + row.Index.ToString());
                        }
                        else {
                            if (!gradeCnt.updateGrade(grade,
                                _grade,
                                bookRecord
                                   ))
                                state = (false, "Error en la fila" + row.Index.ToString());
                        }
                    }
                    updateUnenrolLabel(state.Item2, state.Item1);
                }
                catch (Exception ex) { updateUnenrolLabel(ex.Message,false); }
            }

        }
    }
}
