using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestIn.Controllers;

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
            if(UserDateBirth.Value.Date.Equals(DateTime.Now) || DateTime.Now<UserDateBirth.Value.Date)
            {
                state = false;
                MessageBox.Show("Error, fecha ingresada de formato incorrecto");
            }
            return state;
        }

        public void ClearAllTextBoxes()
        {
            txtDNI.ResetText();
            txtCUILL.ResetText();
            txtTitle.ResetText();
            txtUserBirthPlace.ResetText();
            txtUserDni.ResetText();
            txtUserEmail.ResetText();
            txtUserEmergencyContact.ResetText();
            txtUserLastName.ResetText();
            txtUserName.ResetText();
            txtUserPhoneNumber.ResetText();
            UserDateBirth.ResetText();
            lblResult.Text = "";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (ValidateObligatoryInformation() && ValidateDate())
            {
                if (cmbUserType.SelectedItem.ToString().Equals("Estudiante")) //Student
                {
                    try
                    {
                        userController.enrolStudent(Int32.Parse(txtUserDni.Text), txtUserEmail.Text,
                            txtUserName.Text, txtUserLastName.Text, UserDateBirth.Value.Date, txtUserBirthPlace.Text, txtUserPhoneNumber.Text, cmbGender.SelectedItem.ToString(), 
                            txtUserEmergencyContact.Text,
                            cbAnalitic.Checked, cbDni.Checked, cbBirthCert.Checked, cbMedicCerf.Checked, cbPhotos.Checked, cbCuil.Checked);
                        lblResult.Text = "Estudiante creado";
                        lblResult.Visible = true;
                        lblStudentCount.Text = userController.countStudents().ToString();
                        StartLableRemovalTimer();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
                else //Teacher
                {
                    try
                    {
                        userController.inputTeacher(Int32.Parse(txtUserDni.Text), txtUserEmail.Text, txtUserName.Text, txtUserLastName.Text,
                            UserDateBirth.Value.Date, txtUserBirthPlace.Text, txtUserPhoneNumber.Text, txtUserEmergencyContact.Text, cmbGender.SelectedItem.ToString(), 
                            txtCUILL.Text, txtTitle.Text);
                        lblResult.Text = "Docente creado";
                        lblResult.Visible = true;
                        lblTeacherCount.Text = userController.countTeachers().ToString();
                        StartLableRemovalTimer();
                        ClearAllTextBoxes();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearAllTextBoxes();
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

        public bool checkUserDependency()
        {
            if(cmbUserType.SelectedItem.ToString().Equals("Estudiante"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loadSearchResults()
        {
            int Integer = 0;
            bool checkState = Int32.TryParse(textBoxSearchBar.Text, out Integer);
            if(checkUserDependency())
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
                refreshUserNameLable(userController.getTeacher(listBoxSearchResults.SelectedItem).FullName());
                btnInsert.Enabled = true;
            }
        }

        private void listBoxSearchResults_DoubleClick(object sender, EventArgs e)
        {
            int index = listBoxSearchResults.SelectedIndex;
            if (index != null || index < 0)
            {
                if(checkUserDependency())
                {
                    refreshUserNameLable(userController.getStudent(listBoxSearchResults.SelectedItem).FullName()); ;
                }
                else
                {
                    refreshUserNameLable(userController.getTeacher(listBoxSearchResults.SelectedItem).FullName());
                }
                btnInsert.Enabled = true;
                listBoxSearchResults.Visible = false;
            }
        }
    }
}
