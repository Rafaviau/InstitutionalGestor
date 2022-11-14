using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Wordprocessing;
using GestIn.Controllers;
using GestIn.Model;

namespace GestIn.UI.Home.Users
{
    public partial class formUser : Form
    {
        userController userController;
        public formUser()
        {
            userController = userController.GetInstance();
            InitializeComponent();
        }

        private void formTeacher_Load(object sender, EventArgs e)
        {
            NullCheck();
            cmbUserType.SelectedIndex = 0;
            cmbGender.SelectedIndex = 0;
        }

        public void NullCheck()
        {
            if (userController.countUsers() != 0)
            {
                lblStudentCount.Text = userController.countStudents().ToString();
                lblTeacherCount.Text = userController.countTeachers().ToString();
            }
        }

        private void cmbUserType_SelectedIndexChanged(object sender, EventArgs e)
        {
            NullifySearchResults();
            ClearScreen();
            checkCurrentState();
        }

        public void checkCurrentState()
        {
            if (cmbUserType.SelectedItem.ToString().Equals("Estudiante"))
            {
                studentPanel.Visible = true;
                teacherPanel.Visible = false;
            }
            else
            {
                studentPanel.Visible = false;
                teacherPanel.Visible = true;
            }
        }

        public bool ValidateObligatoryInformation()
        {
            bool state = true;
            if (txtUserDni.Equals("") || txtUserEmail.Equals("") || txtUserLastName.Equals("") || txtUserName.Equals(""))
            {
                state = false;
                MessageBox.Show("Complete todos los campos obligatorios {X}");
            }
            return state;
        }
        public bool ValidateDate()
        {
            bool state = true;
            if (UserDateBirth.Value.Date.Equals(DateTime.Now) || DateTime.Now < UserDateBirth.Value.Date)
            {
                state = false;
                MessageBox.Show("Error, fecha ingresada de formato incorrecto");
            }
            return state;
        }

        public void ClearScreen()
        {
            txtCuil.ResetText();
            txtTitle.ResetText();
            txtUserBirthPlace.ResetText();
            txtUserDni.ResetText();
            txtUserEmail.ResetText();
            txtUserEmergencyContact.ResetText();
            txtUserLastName.ResetText();
            txtUserName.ResetText();
            txtUserPhoneNumber.ResetText();
            txtOcupation.ResetText();
            txtHealthcare.ResetText();
            txtWorkHours.ResetText();
            UserDateBirth.ResetText();
            lblUserResult.Text = "";
            lblSearchInfo.Text = "";
            chkAnalitic.Checked = false;
            chkBirthCertificate.Checked = false;
            chkCooperative.Checked = false;
            chkCUIL.Checked = false;
            chkDNI.Checked = false;
            chkMedicalCertificate.Checked = false;
            chkPhoto.Checked = false;
        }

        public void NullifySearchResults()
        {
            listBoxSearchResults.DataSource = null;
            listBoxSearchResults.ResetText();
        }

        public void SetTextBoxValues(object userType)
        {
            if(cmbUserType.SelectedItem.ToString().Equals("Estudiante"))
            {
                Student student = userController.getStudent(userType);
                txtUserBirthPlace.Text = student.User.PlaceOfBirth;
                txtUserDni.Text = (student.User.Dni).ToString();
                txtUserEmail.Text = (student.LoginInformation.Email).ToString(); 
                txtUserLastName.Text = (student.User.LastName).ToString(); 
                txtUserName.Text = (student.User.Name).ToString(); 
                cmbGender.SelectedText = student.User.Gender;
                txtUserPhoneNumber.Text = student.User.PhoneNumbre;
                txtUserEmergencyContact.Text = student.User.EmergencyPhoneNumber;
                UserDateBirth.Text = ((DateTime)student.User.DateOfBirth).ToString();
                txtOcupation.Text = student.WorkActivity;
                txtWorkHours.Text = student.WorkingHours.ToString();
                txtHealthcare.Text = student.SocialWork;

                chkAnalitic.Checked = student.HighSchoolTitPhotocopy;
                chkBirthCertificate.Checked = student.BirthCertificate;
                chkCUIL.Checked = student.CuilConstansy;
                chkDNI.Checked = student.DniPhotocopy;
                chkMedicalCertificate.Checked = student.MedicalCertificate;
                chkPhoto.Checked = student.Photo4x4;
                chkCooperative.Checked = student.Cooperative;
            }
            else
            {
                Teacher teacher = userController.getTeacher(userType);
                txtUserBirthPlace.Text = teacher.User.PlaceOfBirth;
                txtUserDni.Text = (teacher.User.Dni).ToString();
                txtUserEmail.Text = (teacher.LoginInformation.Email).ToString(); 
                txtUserLastName.Text = (teacher.User.LastName).ToString(); 
                txtUserName.Text = (teacher.User.Name).ToString(); 
                txtCuil.Text = (teacher.Cuil).ToString();
                cmbGender.SelectedText = teacher.User.Gender;
                txtUserPhoneNumber.Text = teacher.User.PhoneNumbre;
                txtTitle.Text = teacher.Titulo;
                txtUserEmergencyContact.Text = teacher.User.EmergencyPhoneNumber;
                UserDateBirth.Text = ((DateTime)teacher.User.DateOfBirth).ToString();
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateObligatoryInformation() && ValidateDate())
            {
                if (checkUserType()) //Student
                {
                    try
                    {
                        userController.enrolStudent(Int32.Parse(txtUserDni.Text), txtUserEmail.Text,
                            txtUserName.Text, txtUserLastName.Text, UserDateBirth.Value.Date, txtUserBirthPlace.Text, txtUserPhoneNumber.Text, cmbGender.SelectedItem.ToString(), txtUserEmergencyContact.Text,
                            txtOcupation.Text, txtWorkHours.Text, txtHealthcare.Text,
                            chkAnalitic.Checked, chkDNI.Checked, chkBirthCertificate.Checked, chkMedicalCertificate.Checked, chkPhoto.Checked, chkCUIL.Checked, chkCooperative.Checked); ;
                        lblResult.Text = "Estudiante creado";
                        lblResult.Visible = true;
                        lblStudentCount.Text = userController.countStudents().ToString();
                        StartLableRemovalTimer();
                    }
                    catch { MessageBox.Show("Estudiante con mismo DNI"); }
                
                }
                else //Teacher
                {
                    try
                    {
                        userController.inputTeacher(Int32.Parse(txtUserDni.Text), txtUserEmail.Text, txtUserName.Text, txtUserLastName.Text,
                            UserDateBirth.Value.Date, txtUserBirthPlace.Text, txtUserPhoneNumber.Text, txtUserEmergencyContact.Text, cmbGender.SelectedItem.ToString(), 
                            txtCuil.Text, txtTitle.Text);
                        lblResult.Text = "Docente creado";
                        lblResult.Visible = true;
                        lblTeacherCount.Text = userController.countTeachers().ToString();
                        StartLableRemovalTimer();
                        
                    }
                    catch { MessageBox.Show("Docente con mismo DNI"); }
                }
            }
            ClearScreen();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateObligatoryInformation() && ValidateDate())
            {
                if (checkUserType()) //Student
                {
                    try
                    {
                        //Work to be done
                        userController.modifyUserStudent(listBoxSearchResults.SelectedItem, Int32.Parse(txtUserDni.Text), txtUserEmail.Text, txtUserName.Text, txtUserLastName.Text,
                            UserDateBirth.Value.Date, txtUserBirthPlace.Text, txtUserPhoneNumber.Text, txtUserEmergencyContact.Text, cmbGender.SelectedItem.ToString(),
                            txtOcupation.Text, txtWorkHours.Text, txtHealthcare.Text, chkAnalitic.Checked, chkDNI.Checked, chkBirthCertificate.Checked, chkMedicalCertificate.Checked,
                            chkPhoto.Checked, chkCUIL.Checked, chkCooperative.Checked);
                        lblResult.Text = "Estudiante modificado";
                        lblResult.Visible = true;
                        StartLableRemovalTimer();
                    }
                    catch { MessageBox.Show("Estudiante con mismo DNI"); }
                }
                else //Teacher
                {
                    try
                    {
                        userController.modifyUserTeacher(listBoxSearchResults.SelectedItem, Int32.Parse(txtUserDni.Text), txtUserEmail.Text, txtUserName.Text, txtUserLastName.Text,
                            UserDateBirth.Value.Date, txtUserBirthPlace.Text, txtUserPhoneNumber.Text, txtUserEmergencyContact.Text, cmbGender.SelectedItem.ToString(),
                            txtCuil.Text, txtTitle.Text);
                        lblResult.Text = "Docente modificado";
                        lblResult.Visible = true;
                        StartLableRemovalTimer();

                    }
                    catch { MessageBox.Show("Docente con mismo DNI"); }
                }
            }
            ClearScreen();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearScreen();
        }

        public void StartLableRemovalTimer()
        {
            lableTimer.Interval = 4000; // 3 segundos
            lableTimer.Tick += lableTimer_Tick;
            lableTimer.Start();
        }

        private void lableTimer_Tick(object sender, EventArgs e)
        {
            lblResult.Visible = false;
            lableTimer.Stop();
        }

        public void refreshUserNameLable(string name)
        {
            lblUserResult.Visible = true;
            lblUserResult.Text = name;
        }

        public bool checkUserType()
        {
            bool dependency = false;
            if(cmbUserType.SelectedItem.ToString().Equals("Estudiante"))
            {
                dependency = true;
            }
            return dependency;
        }

        private void loadSearchResults()
        {
            int Integer = 0;
            bool checkState = Int32.TryParse(textBoxSearchBar.Text, out Integer);
            if(checkUserType())
            {
                if (checkState)
                {
                    listBoxSearchResults.DataSource = userController.searchBoxStudentWithInt(Int32.Parse(textBoxSearchBar.Text));
                }
                else
                {
                    listBoxSearchResults.DataSource = userController.searchBoxStudentWithString(textBoxSearchBar.Text);
                }
            }
            else
            {
                if (checkState)
                {
                    listBoxSearchResults.DataSource = userController.searchBoxTeacherWithInt(Int32.Parse(textBoxSearchBar.Text));
                }
                else
                {
                    listBoxSearchResults.DataSource = userController.searchBoxTeacherWithString(textBoxSearchBar.Text);
                }
            }
            
        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearchBar.Text.Length == 0)
            {
                listBoxSearchResults.Visible = false;
            }
            else
            {
                listBoxSearchResults.Visible = true;
                loadSearchResults();
            }
        }

        private void textBoxSearchBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                listBoxSearchResults.Focus();
            }
        }

        private void listBoxSearchResults_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && listBoxSearchResults.SelectedIndex <= 0)
            {
                listBoxSearchResults.ClearSelected();
                textBoxSearchBar.Focus();
            }
            if (e.KeyCode == Keys.Enter && listBoxSearchResults.SelectedIndex >= 0)
            {
                refreshUserNameLable(userController.getTeacher(listBoxSearchResults.SelectedItem).ToString());
                btnInsert.Enabled = true;
            }
        }

        private void listBoxSearchResults_DoubleClick(object sender, EventArgs e)
        {
            ClearScreen();
            int index = listBoxSearchResults.SelectedIndex;
            if (index != null || index < 0)
            {
                if(checkUserType())
                {
                    refreshUserNameLable(userController.getStudent(listBoxSearchResults.SelectedItem).FullName());
                    SetTextBoxValues(listBoxSearchResults.SelectedItem);
                }
                else
                {
                    refreshUserNameLable(userController.getTeacher(listBoxSearchResults.SelectedItem).ToString());
                    SetTextBoxValues(listBoxSearchResults.SelectedItem);
                }
                btnInsert.Enabled = true;
                listBoxSearchResults.Visible = false;
            }
        }

        private void studentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
