using GestIn.Controllers;
using GestIn.Model;
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
            var list = examCnt.loadStudentExam(studentDni);
            if (list.Item1 == null) { MessageBox.Show(list.Item2); }
            else { 
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
        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedStudentId != -1) {
                var a = examEnrolCnt.verifyCorrelatives(Int32.Parse(dgvExams.Rows[dgvExams.CurrentCell.RowIndex].Cells[2].Value.ToString()),selectedStudentId);
            }
        }
    }
}
