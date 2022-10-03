using GestIn.Controllers;
using GestIn.Model;
using GestIn.UI.Home.Grades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestIn.UI.Home.Students
{
    public partial class formAcademicRecord : Form
    {
        userController cntUser = userController.GetInstance();
        careerEnrolmentController cntCareerEnrolment = careerEnrolmentController.GetInstance();
        gradeContorller cntGrades = gradeContorller.GetInstance();
        public formAcademicRecord()
        {
            InitializeComponent();
        }

        public void setStudent(Student student)
        {
            txtStudent.Text =  student.User.LastName + " " + student.User.Name;
            txtStudentDni.Text = student.User.Dni.ToString();
            txtStudentPhoneNumber.Text = student.User.PhoneNumbre;
            txtStudentEmail.Text = student.LoginInformation.Email;
            txtBirthDate.Text = student.User.DateOfBirth.ToString();
            txtBirthPlace.Text = student.User.PlaceOfBirth;
            txtEmergencyContact.Text = student.User.EmergencyPhoneNumber;
            txtGender.Text = student.User.Gender;

            cbAnalitic.Checked = student.HighSchoolTitPhotocopy;
            cbBirthCert.Checked = student.BirthCertificate;
            cbCuil.Checked = student.CuilConstansy;
            cbDni.Checked = student.DniPhotocopy;
            cbMedicCerf.Checked = student.MedicalCertificate;
            cbPhotos.Checked = student.Photo4x4;

        }
        public void AddSubjectRecord(int id, int yearInCarrer, string subject, string enrolmentAprovalYear, string acreditationType, int grade, DateTime approvalDate, string bookRecord)
        {
            dgvSubjectsRecord.Rows.Add(id, yearInCarrer, subject, enrolmentAprovalYear, acreditationType, grade, approvalDate, bookRecord);
        }

        public void AddSubjectRecord(int id, int yearInCarrer, string subject)
        {
            dgvSubjectsRecord.Rows.Add(id, yearInCarrer, subject);
        }

        private void FormAcademicRecord_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPersonalData_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (searchBox.Text.Length == 0) { lbSearch.Visible = false; }
            else
            {
                lbSearch.Visible = true;
                loadLbSeach();
            }

        }
        void loadLbSeach()
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
                dgvSubjectsRecord.Rows.Clear();
                Student student = (Student)lbSearch.SelectedItem;
                setStudent(student);
                getStudentCareerInfo(student.User.Dni);
                getStudentGrades(student.User.Dni);
            }
        }

        private void lbSearch_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dgvSubjectsRecord.Rows.Clear();
            int index = this.lbSearch.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Student student = (Student)lbSearch.SelectedItem;
                setStudent(student);
                getStudentCareerInfo(student.User.Dni);
                getStudentGrades(student.User.Dni);
            }
            lbSearch.Visible = false;
        }
        void getStudentCareerInfo(int dni)
        {
            cbbCarrer.Items.Clear();
            var ListCareer = cntCareerEnrolment.searchCareerEnrolment(dni);
            foreach (CareerEnrolment item in ListCareer)
            {
                cbbCarrer.Items.Add(item);
            }
            cbbCarrer.SelectedIndex = 0;
        }
        void getStudentGrades(int dni)
        {
            var list = cntGrades.getStudentGrades(dni);
            foreach (Grade item in list) {
                AddSubjectRecord(item.Id, item.Subject.YearInCareer, item.Subject.Name,"4444" ,item.AccreditationType, item.Grade1, (DateTime)item.AccreditationDate, item.BookRecord);
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            formGrades formGrade = new formGrades(txtStudentDni.Text);
            formGrade.ShowDialog();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            TempStudentCreate formGrade = new TempStudentCreate();
            formGrade.ShowDialog();
        }
    }
}