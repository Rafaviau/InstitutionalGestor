using GestIn.Controllers;
using GestIn.Model;
using GestIn.UI.Home.Grades;
using GestIn.UI.Home.Users;
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
        subjectEnrolmentController cntSubjectEnrolment = subjectEnrolmentController.GetInstance();
        gradeContorller cntGrades = gradeContorller.GetInstance();
        careerController cntCareer = careerController.GetInstance();
        public formAcademicRecord()
        {
            InitializeComponent();
        }

        public void setStudent(Student student)
        {
            lblStudentId.Text = student.Id.ToString();
            txtStudent.Text =  student.User.LastName + " " + student.User.Name;
            txtStudentDni.Text = student.User.Dni.ToString();
            txtStudentPhoneNumber.Text = student.User.PhoneNumbre;
            txtStudentEmail.Text = student.LoginInformation.Email;
            txtBirthDate.Text = student.User.DateOfBirth?.ToString().Substring(0,10);
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
        public void AddSubjectRecord( int idGrade,int yearInCarrer, Subject subject, string enrolmentAprovalYear, string acreditationType, string approvalDate,int grade,  string bookRecord,int idEnrolment)
        {
            dgvSubjectsRecord.Rows.Add( idGrade,yearInCarrer, subject, enrolmentAprovalYear, acreditationType, approvalDate, grade, bookRecord,idEnrolment);
        }

        public void AddSubjectRecord(int idEnrolment, int yearInCarrer, Subject subject,int enrolmentAprovalYear, bool acreditationType)
        {
            string acctype = "Presencial";
            if (!acreditationType) { acctype = "Libre"; }
            dgvSubjectsRecord.Rows.Add(null,yearInCarrer, subject, enrolmentAprovalYear, acctype, null,null,null,idEnrolment);
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
                dgvSubjectsRecord.Rows.Clear();
                Student student = (Student)lbSearch.SelectedItem;
                setStudent(student);
                getStudentCareerInfo(student.User.Dni);
                getStudentGrades(student.User.Dni);
                lbSearch.Visible = false;
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
        private void getStudentCareerInfo(int dni)
        {
            cbbCarrer.Items.Clear();
            var ListCareer = cntCareerEnrolment.searchCareerEnrolment(dni);
            foreach (CareerEnrolment item in ListCareer)
            {
                cbbCarrer.Items.Add(item);
            }
            if (ListCareer.Count > 0) {cbbCarrer.SelectedIndex = 0; }
            
        }
        private void getStudentGrades(int dni)
        {
            var list = cntGrades.getStudentGrades(dni);
            var list2 = cntSubjectEnrolment.getEnrolments(dni);
            list2.RemoveAll(x => list.Any(y => y.Subject.Name == x.Subject.Name));
            foreach (Grade item in list) {
                var subjectTaken =  cntSubjectEnrolment.getEnrolment(Int32.Parse(txtStudentDni.Text), item.Subject, cbbCarrer.SelectedItem);
                if(subjectTaken!=null)
                    AddSubjectRecord( item.Id,item.Subject.YearInCareer, item.Subject, subjectTaken.Year.ToString(), item.AccreditationType, item.AccreditationDate.Value.ToString("dd/MM/yyyy"), item.Grade1, item.BookRecord, subjectTaken.Id);
            }
            foreach (SubjectEnrolment item in list2)
            {
                AddSubjectRecord( item.Id,item.Subject.YearInCareer, item.Subject,item.Year,item.Presential);
            }
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            formGrades formGrade = new formGrades(txtStudentDni.Text);
            formGrade.ShowDialog();
            //--------------------------------cambiar---------------------------------//
            if (!txtStudentDni.Text.Equals("")){
                dgvSubjectsRecord.Rows.Clear();
                getStudentGrades(Int32.Parse(txtStudentDni.Text));
            }
            
            //-----------------------------------------------------------------------//
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            formUser userForm = new formUser();
            userForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TempCareer formCareer = new TempCareer();
            formCareer.ShowDialog();
        }

        private void dgvSubjectsRecord_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[0].Value == null)
            {
                var subject = (Subject)dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[2].Value;
                formEditGrade formEditGrade_ = new formEditGrade(
                    Int32.Parse(dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[8].Value.ToString()),
                    txtStudent.Text,
                    subject.Name,
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[3].Value.ToString(),
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[4].Value.ToString().Equals("Presencial"),
                    Int32.Parse(lblStudentId.Text),
                    subject
                    );
                formEditGrade_.ShowDialog();
            }
            else {
                formEditGrade formEditGrade_ = new formEditGrade(
                    Int32.Parse(dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[0].Value.ToString()),
                    Int32.Parse(dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[8].Value.ToString()),
                    txtStudent.Text, 
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[2].Value.ToString(),
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[3].Value.ToString(),
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[4].Value.ToString().Equals("Presencial"),
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[6].Value.ToString(),
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[7].Value.ToString(),
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[5].Value.ToString(),
                    dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[4].Value.ToString()
                );
                formEditGrade_.ShowDialog();
            }
            //--------------------------------cambiar para no renderizar todo denuevo---------------------------------//
            dgvSubjectsRecord.Rows.Clear();
            getStudentGrades(Int32.Parse(txtStudentDni.Text));
            //-----------------------------------------------------------------------//
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[0].Value == null))
                {
                    var confirmResult = MessageBox.Show("Are you sure to delete this item ??",
                                                         "Confirm Delete!!",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        if (
                        cntGrades.deleteGrade(Int32.Parse(dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[0].Value.ToString())) &&
                        cntSubjectEnrolment.deleteEnrolment(Int32.Parse(dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[8].Value.ToString()))
                        )
                        {
                            dgvSubjectsRecord.Rows.RemoveAt(dgvSubjectsRecord.CurrentCell.RowIndex);
                        }
                    }

                }
                else
                {
                    if(cntSubjectEnrolment.deleteEnrolment(Int32.Parse(dgvSubjectsRecord.Rows[dgvSubjectsRecord.CurrentCell.RowIndex].Cells[8].Value.ToString())))
                    {
                        dgvSubjectsRecord.Rows.RemoveAt(dgvSubjectsRecord.CurrentCell.RowIndex);
                    }
                }
            }
            catch (Exception ex){ }

            
        }
        private void cbbCarrer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvSubjectsRecord.Rows.Clear();
            getStudentGrades(Convert.ToInt32(txtStudentDni.Text));

        }
    }
}