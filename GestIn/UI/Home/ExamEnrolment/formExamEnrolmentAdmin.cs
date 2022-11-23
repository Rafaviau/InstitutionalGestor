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
    public partial class formExamEnrolmentAdmin : Form
    {
        userController cntUser = userController.GetInstance();
        examController examCnt = examController.GetInstance();
        examEnrolmentController examEnrolCnt = examEnrolmentController.GetInstance();
        int selectedStudentId = -1;
        public formExamEnrolmentAdmin()
        {
            InitializeComponent();
        }
        private void loadExams(int studentDni, string studentName, int studentId)
        {
            selectedStudentId = studentId;
            lblDni.Text = studentDni.ToString();
            lblStudent.Text = studentName;
            dgvExams.Rows.Clear();
            var list = examCnt.loadEnableEnrolmentExams(studentDni);
            if (list.Item1 == null) { MessageBox.Show(list.Item2); }
            else if (list.Item1.Count == 0) {
                formShowInfo forminfo = new formShowInfo("No hay examenes disponibles para este estudiante", Resources.CloudError);
                forminfo.ShowDialog();
            }
            else
            {
                foreach (Exam e in list.Item1)
                {
                    addExam(e);
                }
            }

        }
        private void addExam(Exam ex)
        {
            int StudentsEnroled = 0;
            dgvExams.Rows.Add(ex.Id,ex.IdSubjectNavigation.Career.Id,ex.IdSubjectNavigation.Id, ex.IdSubjectNavigation.Career.Name, ex.IdSubjectNavigation.Name, ex.Date);
        }
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length == 0) { lbSearch.Visible = false; }
            else
            {
                lbSearch.Visible = true;
                lbSearch.BringToFront();
                loadLbSeach();
            }
        }
        private void loadLbSeach()
        {
            int Out = 0;
            bool checkInt = Int32.TryParse(searchBox.Text, out Out);
            if (checkInt)
            {
                lbSearch.DataSource = cntUser.searchBoxStudentWithInt(Int32.Parse(searchBox.Text));
            }
            else
            {
                lbSearch.DataSource = cntUser.searchBoxStudentWithString(searchBox.Text);
            }
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                lbSearch.Focus();
            }
        }

        private void lbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && lbSearch.SelectedIndex <= 0)
            {
                lbSearch.ClearSelected();
                searchBox.Focus();
            }
            if (e.KeyCode == Keys.Enter && lbSearch.SelectedIndex >= 0)
            {
                Student student = (Student)lbSearch.SelectedItem;
                loadExams(student.User.Dni,student.User.Name + " " + student.User.LastName,student.Id);
                searchBox.Clear();
            }
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("¿Esta seguro que desea realizar la inscripcion?", "Confirmar", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in dgvExams.SelectedRows) {
                    int subjectId = Convert.ToInt32(item.Cells[2].Value);
                    int examId = Convert.ToInt32(item.Cells[0].Value);
                    if (!examEnrolCnt.verifyCorrelatives(subjectId, selectedStudentId).Item1)
                    {
                        var confirmInscription = MessageBox.Show("El estudiante no se encuentra en codicion de inscrbirse a este examen.¿Desea hacerlo igualmente?", "Confirmar", MessageBoxButtons.YesNo);
                        if (confirmInscription == DialogResult.Yes)
                        {
                            if (examEnrolCnt.enrolStudentToExam(selectedStudentId, subjectId)) { 
                                dgvExams.Rows.Remove(item);
                            }
                        }
                    }
                    else { 
                        if(examEnrolCnt.enrolStudentToExam(selectedStudentId, examId))
                        {
                            dgvExams.Rows.Remove(item);
                        } 
                    }
                }
                
            }
        }
    }
}
